using System;

namespace Strategy
{
	class DeepFrying : AbstractCook
	{
		public override void Cook(string food)
		{
			Console.WriteLine("\nCooking " + food + " by deep frying it");
		}
	}
}
