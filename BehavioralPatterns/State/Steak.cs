﻿using System;

namespace State
{
	class Steak
	{
		private State _state;
		private string _beefCut;

		public Steak(string beefCut)
		{
			_beefCut = beefCut;
			_state = new Rare(0.0, this);
		}

		public double CurrentTemp => _state.CurrentTemp;

		public State State
		{
			get => _state;
			set => _state = value;
		}

		public void AddTemp(double amount)
		{
			_state.AddTemp(amount);
			Console.WriteLine("Increased temperature by {0} degrees.", amount);
			Console.WriteLine(" Current temp is {0}", CurrentTemp);
			Console.WriteLine(" Status is {0}", State.GetType().Name);
			Console.WriteLine("");
		}

		public void RemoveTemp(double amount)
		{
			_state.RemoveTemp(amount);
			Console.WriteLine("Decreased temperature by {0} degrees.", amount);
			Console.WriteLine(" Current temp is {0}", CurrentTemp);
			Console.WriteLine(" Status is {0}", State.GetType().Name);
			Console.WriteLine("");
		}
	}
}
