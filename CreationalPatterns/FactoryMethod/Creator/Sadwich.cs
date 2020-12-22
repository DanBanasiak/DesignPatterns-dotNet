using FactoryMethod.Abstract;
using System.Collections.Generic;

namespace FactoryMethod.Creator
{
	abstract class Sandwich
	{
		public Sandwich()
		{
			CreateIngredients();
		}

		//Factory method
		public abstract void CreateIngredients();

		public List<Ingredient> Ingredients { get; } = new List<Ingredient>();
	}
}
