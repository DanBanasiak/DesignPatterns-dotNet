using Bridge.Implementor;

namespace Bridge.Abstraction
{
	public abstract class SendOrder
	{
		public IOrderingSystem Restaurant;
		public abstract void Send();
	}
}
