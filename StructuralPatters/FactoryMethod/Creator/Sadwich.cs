using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Creator
{
	abstract class Sandwich
	{
		private List<Ingredient> _ingredients = new List<Ingredient>();

		public Sandwich()
		{
			CreateIngredients();
		}

		//Factory method
		public abstract void CreateIngredients();

		public List<Ingredient> Ingredients => _ingredients;
	}
}
