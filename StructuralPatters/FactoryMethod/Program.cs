using FactoryMethod.Creator;
using FactoryMethod.Factory;
using System;
using System.Collections.Generic;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var sandwiches = new List<Sandwich>
			{
				new TurkeySandwich(),
				new Dagwood()
			};


			foreach (var sandwich in sandwiches)
			{
				Console.WriteLine("\nSandwich: " + sandwich.GetType().Name + " ");
				foreach (var ingredient in sandwich.Ingredients)
				{
					Console.WriteLine("Ingredient: " + ingredient.GetType().Name);
				}
			}

			Console.ReadKey();
		}
	}
}
