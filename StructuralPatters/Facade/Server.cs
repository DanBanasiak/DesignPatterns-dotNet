using System;

namespace Facade
{
	class Server
	{
		private ColdPrep coldPrep = new ColdPrep();
		private Bar bar = new Bar();
		private HotPrep hotPrep = new HotPrep();

		public Order PlaceOrder(Patron patron, int coldAppID, int hotEntreeID, int drinkID)
		{
			Console.WriteLine("{0} places order for cold app #" + coldAppID.ToString()
								+ ", hot entree #" + hotEntreeID.ToString()
								+ ", and drink #" + drinkID.ToString() + ".", patron.Name);

			var order = new Order
			{
				Appetizer = coldPrep.PrepDish(coldAppID),
				Entree = hotPrep.PrepDish(hotEntreeID),
				Drink = bar.PrepDish(drinkID)
			};

			return order;
		}
	}
}
