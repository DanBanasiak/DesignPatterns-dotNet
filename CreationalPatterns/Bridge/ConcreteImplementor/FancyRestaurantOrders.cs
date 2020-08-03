using Bridge.Implementor;
using System;

namespace Bridge
{
	public class FancyRestaurantOrders : IOrderingSystem
	{
		public void Place(string order)
		{
			Console.WriteLine("Placing order for " + order + " at the Fancy Restaurant.");
		}
	}
}
