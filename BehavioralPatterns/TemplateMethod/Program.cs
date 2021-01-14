using System;

namespace TemplateMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			var sourdough = new Sourdough();
			sourdough.Make();

			var twelveGrain = new TwelveGrain();
			twelveGrain.Make();

			var wholeWheat = new WholeWheat();
			wholeWheat.Make();

			Console.ReadKey();
		}
	}
}
