using AbstractFactory.Abstract;

namespace AbstractFactory.Factory
{
	abstract class RecipeFactory
	{
		public abstract Sandwich CreateSandwich();
		public abstract Dessert CreateDessert();
	}
}
