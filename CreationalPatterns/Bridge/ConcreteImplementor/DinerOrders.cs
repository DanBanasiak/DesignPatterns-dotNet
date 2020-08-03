using Bridge.Implementor;
using System;

namespace Bridge.ConcreteImplementor
{
	public class DinerOrders : IOrderingSystem
	{
		public void Place(string order)
		{
			Console.WriteLine("Placing order for " + order + " at the Diner.");
		}
	}
}
