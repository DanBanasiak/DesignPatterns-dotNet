using System;

namespace PrototypePattern
{
	class Sandwich : SandwichPrototype
	{
		private string Bread;
		private string Meat;
		private string Cheese; //I will use this pun everywhere I can
		private string Veggies;

		public Sandwich(string bread, string meat, string cheese, string veggies)
		{
			Bread = bread;
			Meat = meat;
			Cheese = cheese;
			Veggies = veggies;
		}

		public override SandwichPrototype Clone()
		{
			string ingredientList = GetIngredientList();
			Console.WriteLine("Cloning sandwich with ingredients: {0}", ingredientList.Remove(ingredientList.LastIndexOf(",")));

			return MemberwiseClone() as SandwichPrototype;
		}

		private string GetIngredientList()
		{
			var ingredientList = "";
			if (!string.IsNullOrWhiteSpace(Bread))
			{
				ingredientList += Bread + ", ";
			}
			if (!string.IsNullOrWhiteSpace(Meat))
			{
				ingredientList += Meat + ", ";
			}
			if (!string.IsNullOrWhiteSpace(Cheese))
			{
				ingredientList += Cheese + ", ";
			}
			if (!string.IsNullOrWhiteSpace(Veggies))
			{
				ingredientList += Veggies + ", ";
			}
			return ingredientList;
		}
	}
}
