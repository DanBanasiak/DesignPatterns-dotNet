using System;

namespace Facade
{
	class Bar : IKitchenSection
	{
		public FoodItem PrepDish(int dishID)
		{
			Console.WriteLine("The Bar is preparing Drink #" + dishID);
			//Go mix the drink
			return new FoodItem()
			{
				DishID = dishID
			};
		}
	}
}
