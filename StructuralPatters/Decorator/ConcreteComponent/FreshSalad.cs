﻿using Decorator.Abstract;
using System;

namespace Decorator
{
	class FreshSalad : RestaurantDish
	{
		private readonly string _greens;
		private readonly string _cheese; //I am going to use this pun everywhere I can
		private readonly string _dressing;

		public FreshSalad(string greens, string cheese, string dressing)
		{
			_greens = greens;
			_cheese = cheese;
			_dressing = dressing;
		}

		public override void Display()
		{
			Console.WriteLine("\nFresh Salad:");
			Console.WriteLine(" Greens: {0}", _greens);
			Console.WriteLine(" Cheese: {0}", _cheese);
			Console.WriteLine(" Dressing: {0}", _dressing);
		}
	}
}
