using System;

// ToyBear interface
public interface ToyBear
{
	void Hug();
}

// Bear interface
public interface Bear
{
	void Maul();
	void Hibernate();
}

// Grizzly class
public class Grizzly : Bear
{
	public void Maul()
	{
		Console.WriteLine("You are mauled by the Grizzly");
	}

	public void Hibernate()
	{
		Console.WriteLine("The Grizzly is hibernating");
	}
}

// TeddyBear class
public class TeddyBear : ToyBear
{
	public void Hug()
	{
		Console.WriteLine("Teddy bear is being hugged by you");
	}
}

// BearAdapter class
public class BearAdapter : ToyBear
{
	private Bear _adaptee;

	public BearAdapter(Bear adaptee)
	{
		_adaptee = adaptee;
	}

	public void Hug()
	{
		_adaptee.Maul();
	}
}

// Main function
class Program
{
	static void Main(string[] args)
	{
		Grizzly grizzly = new Grizzly();
		TeddyBear teddyBear = new TeddyBear();
		BearAdapter bearAdapter = new BearAdapter(grizzly);

		Console.WriteLine("Running Grizzly functions");
		grizzly.Maul();
		grizzly.Hibernate();

		Console.WriteLine("\nRunning TeddyBear functions");
		teddyBear.Hug();

		Console.WriteLine("\nRunning BearAdapter functions");
		bearAdapter.Hug();
	}
}
