using System;

namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Hello!  I'll be your server today. What is your name?");
			var name = Console.ReadLine();

			var patron = new Patron(name);

			Console.WriteLine("Hello " + patron.Name + ". What appetizer would you like? (1-15):");
			var appID = int.Parse(Console.ReadLine());

			Console.WriteLine("That's a good one.  What entree would you like? (1-20):");
			var entreeID = int.Parse(Console.ReadLine());

			Console.WriteLine("A great choice!  Finally, what drink would you like? (1-60):");
			var drinkID = int.Parse(Console.ReadLine());

			Console.WriteLine("I'll get that order in right away.");

			var server = new Server();
			server.PlaceOrder(patron, appID, entreeID, drinkID);

			Console.ReadKey();
		}
	}
}
