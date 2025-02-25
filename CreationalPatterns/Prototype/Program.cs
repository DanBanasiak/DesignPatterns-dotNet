﻿using System;

namespace PrototypePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var sandwichMenu = new SandwichMenu();

			// Initialize with default sandwiches
			sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
			sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
			sandwichMenu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

			// Catering manager adds custom sandwiches
			sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Tomato, Onion, Olives");
			sandwichMenu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
			sandwichMenu["Vegetarian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

			// Now we can clone the sandwiches.
			var sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
			var sandwich2 = sandwichMenu["ThreeMeatCombo"].Clone() as Sandwich;
			var sandwich3 = sandwichMenu["Vegetarian"].Clone() as Sandwich;

			Console.ReadKey();
		}
	}
}
