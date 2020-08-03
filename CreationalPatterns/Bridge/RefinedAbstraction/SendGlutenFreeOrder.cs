using Bridge.Abstraction;

namespace Bridge.RefinedAbstraction
{
	public class SendGlutenFreeOrder : SendOrder
	{
		public override void Send()
		{
			Restaurant.Place("Gluten-Free Order");
		}
	}
}
