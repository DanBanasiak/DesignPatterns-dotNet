using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Abstract
{
	public abstract class SoftDrink
	{
		public int Calories { get; set; }

		public List<SoftDrink> Flavors { get; set; }

		public SoftDrink(int calories)
		{
			Calories = calories;
			Flavors = new List<SoftDrink>();
		}

		public void DisplayCalories()
		{
			Console.WriteLine(GetType().Name + ": " + Calories.ToString() + " calories.");
			foreach (SoftDrink drink in Flavors)
			{
				drink.DisplayCalories();
			}
		}
	}
}
