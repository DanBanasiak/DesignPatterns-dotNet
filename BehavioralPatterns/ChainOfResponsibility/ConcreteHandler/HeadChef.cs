using System;
namespace ChainOfResponsibility
{
	class HeadChef : Approver
	{
		public override void ProcessRequest(PurchaseOrder purchase)
		{
			if (purchase.Price < 1000)
			{
				Console.WriteLine("{0} approved purchase request #{1}", GetType().Name, purchase.RequestNumber);
			}
			else if (supervisor != null)
			{
				supervisor.ProcessRequest(purchase);
			}
		}
	}
}
