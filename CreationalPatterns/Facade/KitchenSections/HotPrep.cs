using System;

namespace Facade
{
	class HotPrep : IKitchenSection
	{
		public FoodItem PrepDish(int dishID)
		{
			Console.WriteLine("Hot Prep is preparing Entree #" + dishID);

			return new FoodItem()
			{
				DishID = dishID
			};
		}
	}
}
