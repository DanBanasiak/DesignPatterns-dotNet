using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction
{
	public class SendDairyFreeOrder : SendOrder
	{
		public override void Send()
		{
			Restaurant.Place("Dairy-Free Order");
		}
	}
}
