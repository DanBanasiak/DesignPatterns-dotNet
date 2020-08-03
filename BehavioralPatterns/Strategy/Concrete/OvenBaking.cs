using System;

namespace Strategy
{
	/// <summary>
	/// A Concrete Strategy class
	/// </summary>
	class OvenBaking : AbstractCook
	{
		public override void Cook(string food)
		{
			Console.WriteLine("\nCooking " + food + " by oven baking it.");
		}
	}
}
