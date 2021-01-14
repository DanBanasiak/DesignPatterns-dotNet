using System;

namespace State
{
	class Steak
	{
		private readonly string _beefCut;

		public Steak(string beefCut)
		{
			_beefCut = beefCut;
			State = new Rare(0.0, this);
		}

		public double CurrentTemp => State.CurrentTemp;

		public State State { get; set; }

		public void AddTemp(double amount)
		{
			State.AddTemp(amount);
			Console.WriteLine("Increased temperature by {0} degrees.", amount);
			Console.WriteLine(" Current temp is {0}", CurrentTemp);
			Console.WriteLine(" Status is {0}", State.GetType().Name);
			Console.WriteLine("");
		}

		public void RemoveTemp(double amount)
		{
			State.RemoveTemp(amount);
			Console.WriteLine("Decreased temperature by {0} degrees.", amount);
			Console.WriteLine(" Current temp is {0}", CurrentTemp);
			Console.WriteLine(" Status is {0}", State.GetType().Name);
			Console.WriteLine("");
		}
	}
}
