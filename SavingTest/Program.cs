using System;
using System.Data.Entity;

public class Person
{
	public int Id {
		get;
		set;
	}

	public string FirstName {
		get;
		set;
	}

	public string LastName {
		get;
		set;
	}
}
public class SimpleContext : DbContext
{
	public SimpleContext () : base("name = ConnStr")
	{
	}
	public DbSet<Person> People { 
		get; 
		set;
	}
}

class MainClass
{
	public static void Main (string[] args)
	{
		Console.WriteLine ("starting...");
		using (var context = new SimpleContext ()) {
			var person = new Person { 
				FirstName = "Joe", 
				LastName = "Bloggs" 
			};

			context.People.Add (person);
			context.SaveChanges ();
		}
	}
}

/*
A null was returned after calling the 'get_ProviderFactory' method on a store provider instance of type 'System.Data.Hsql.SharpHsqlConnection'.
The store provider might not be functioning correctly.
*/
