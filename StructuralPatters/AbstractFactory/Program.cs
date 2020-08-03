using AbstractFactory.Abstract;
using AbstractFactory.Factory;
using System;

namespace AbstractFactory
{

	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Do you prefer:\n1. Mc Donald's\n2. KFC");

			var input = Console.ReadLine();

			int.TryParse(input, out var result);
			RecipeFactory factory;

			switch (result)
			{
				case 1:
					factory = new McDonaldsFactory();
					break;
				case 2:
					factory = new KfcFactory();
					break;
				default:
					factory = new McDonaldsFactory();
					break;
			}

			Sandwich sandwich = factory.CreateSandwich();
			Dessert dessert = factory.CreateDessert();

			Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
			Console.WriteLine("Dessert: " + dessert.GetType().Name);

			Console.ReadKey();
		}
	}
}
