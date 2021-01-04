using System;

namespace Mediator
{
	class SouthConcessionStand : ConcessionStand
	{
		public SouthConcessionStand(IMediator mediator) : base(mediator)
		{
		}

		public void Send(string message)
		{
			Console.WriteLine("South Concession Stand sends message: " + message);
			_mediator.SendMessage(message, this);
		}

		public void Notify(string message)
		{
			Console.WriteLine("South Concession Stand gets message: " + message);
		}
	}
}
