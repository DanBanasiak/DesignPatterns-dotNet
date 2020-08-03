using System;
using System.Collections.Generic;

namespace Builder
{
	class Sandwich
	{
		private readonly string _sandwichType;
		public List<string> Ingredients; 

		public Sandwich(string sandwichType)
		{
			_sandwichType = sandwichType;
			Ingredients = new List<string>();
		}

		public void Show()
		{
			Console.WriteLine("\nProduct: {0}", _sandwichType);
			Ingredients.ForEach(x => Console.WriteLine(x));
		}
	}

}
