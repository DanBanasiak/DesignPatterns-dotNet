using System;

namespace Proxy
{
	class Server : IServer
	{
		private string _order;
		public void TakeOrder(string order)
		{
			Console.WriteLine("Server takes order for " + order + ".");
			_order = order;
		}

		public string DeliverOrder() => _order;

		public void ProcessPayment(string payment)
		{
			Console.WriteLine("Payment for order (" + payment + ") processed.");
		}
	}
}
