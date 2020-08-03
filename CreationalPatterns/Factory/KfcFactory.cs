using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.Factory
{
	class KfcFactory : RecipeFactory
	{
		public override Dessert CreateDessert() => new SaltedCaramel();

		public override Sandwich CreateSandwich() => new Twister();
	}
}
