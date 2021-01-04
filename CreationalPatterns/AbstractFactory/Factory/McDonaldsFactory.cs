using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.Factory
{
	class McDonaldsFactory : RecipeFactory
	{
		public override Sandwich CreateSandwich() => new BaconBBQBurger();
		public override Dessert CreateDessert() => new McFlurry();
	}
}
