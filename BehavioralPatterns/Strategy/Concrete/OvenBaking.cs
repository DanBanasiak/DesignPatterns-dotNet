using System;

namespace Strategy
{
	class OvenBaking : AbstractCook
	{
		public override void Cook(string food)
		{
			Console.WriteLine("\nCooking " + food + " by oven baking it.");
		}
	}
}
