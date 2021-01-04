using Decorator.Abstract;
using System;

namespace Decorator
{
	class Pasta : RestaurantDish
	{
		private readonly string _pastaType;
		private readonly string _sauce;

		public Pasta(string pastaType, string sauce)
		{
			_pastaType = pastaType;
			_sauce = sauce;
		}

		public override void Display()
		{
			Console.WriteLine("\nClassic Pasta:");
			Console.WriteLine(" Pasta: {0}", _pastaType);
			Console.WriteLine(" Sauce: {0}", _sauce);
		}
	}
}
