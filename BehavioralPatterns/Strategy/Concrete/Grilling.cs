using System;

namespace Strategy
{
	/// <summary>
	/// A Concrete Strategy class
	/// </summary>
	class Grilling : AbstractCook
	{
		public override void Cook(string food)
		{
			Console.WriteLine("\nCooking " + food + " by grilling it.");
		}
	}
}
