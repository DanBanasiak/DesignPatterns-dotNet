namespace Mediator
{
	abstract class ConcessionStand
	{
		protected IMediator _mediator;

		public ConcessionStand(IMediator mediator)
		{
			_mediator = mediator;
		}
	}
}
