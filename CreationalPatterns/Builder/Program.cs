using Builder.Builders;
using System;

namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractBuilder builder;

			var shop = new Director();

			builder = new HamAndCheese();
			shop.Assemble(builder);
			builder.Sandwich.Show();

			builder = new BLT();
			shop.Assemble(builder);
			builder.Sandwich.Show();


			// Wait for user
			Console.ReadKey();
		}
	}
}
