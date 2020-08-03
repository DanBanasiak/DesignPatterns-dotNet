using AbstractFactory.Abstract;
using AbstractFactory.ConcreteProduct;

namespace AbstractFactory.Factory
{
	class McDonaldsFactory : RecipeFactory
	{
		public override Sandwich CreateSandwich()
		{
			return new BaconBBQBurger();
		}

		public override Dessert CreateDessert()
		{
			return new McFlurry();
		}
	}
}
