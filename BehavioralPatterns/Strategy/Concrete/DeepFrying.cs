using System;

namespace Strategy
{
	/// <summary>
	/// A Concrete Strategy class
	/// </summary>
	class DeepFrying : AbstractCook
	{
		public override void Cook(string food)
		{
			Console.WriteLine("\nCooking " + food + " by deep frying it");
		}
	}
}
