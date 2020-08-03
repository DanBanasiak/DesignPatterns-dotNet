using System;

namespace Facade
{
	class ColdPrep : IKitchenSection
	{
		public FoodItem PrepDish(int dishID)
		{
			Console.WriteLine("Cold Prep is preparing Appetizer #" + dishID);

			return new FoodItem()
			{
				DishID = dishID
			};
		}
	}
}
