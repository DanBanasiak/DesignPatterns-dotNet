namespace Mediator
{
	abstract class ConcessionStand
	{
		protected IMediator mediator;

		public ConcessionStand(IMediator mediator)
		{
			this.mediator = mediator;
		}
	}
}
