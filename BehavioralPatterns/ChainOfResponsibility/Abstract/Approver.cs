namespace ChainOfResponsibility
{
	abstract class Approver
	{
		protected Approver _supervisor;

		public void SetSupervisor(Approver supervisor)
		{
			_supervisor = supervisor;
		}

		public abstract void ProcessRequest(PurchaseOrder purchase);
	}
}