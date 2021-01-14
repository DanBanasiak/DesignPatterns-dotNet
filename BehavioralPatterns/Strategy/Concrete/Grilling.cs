using System;

namespace Strategy
{
	class Grilling : AbstractCook
	{
		public override void Cook(string food)
		{
			Console.WriteLine("\nCooking " + food + " by grilling it.");
		}
	}
}
