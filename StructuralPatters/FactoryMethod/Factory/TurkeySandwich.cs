using FactoryMethod.ConcreteProduct;
using FactoryMethod.Creator;

namespace FactoryMethod.Factory
{
	class TurkeySandwich : Sandwich
	{
		public override void CreateIngredients()
		{
			Ingredients.Add(new Bread());
			Ingredients.Add(new Mayonnaise());
			Ingredients.Add(new Lettuce());
			Ingredients.Add(new Turkey());
			Ingredients.Add(new Turkey());
			Ingredients.Add(new Bread());
		}
	}
}
