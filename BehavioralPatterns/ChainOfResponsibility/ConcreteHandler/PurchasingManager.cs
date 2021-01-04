using System;
namespace ChainOfResponsibility
{
	class PurchasingManager : Approver
	{
		public override void ProcessRequest(PurchaseOrder purchase)
		{
			if (purchase.Price < 2500)
			{
				Console.WriteLine("{0} approved purchase request #{1}", GetType().Name, purchase.RequestNumber);
			}
			else if (_supervisor != null)
			{
				_supervisor.ProcessRequest(purchase);
			}
		}
	}
}
