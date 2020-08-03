using System;

namespace Adapter
{
	class Meat
	{
		protected string MeatName;
		protected float SafeCookTempFahrenheit;
		protected float SafeCookTempCelsius;
		protected double CaloriesPerOunce;
		protected double ProteinPerOunce;

		public Meat(string meat)
		{
			MeatName = meat;
		}

		public virtual void LoadData()
		{
			Console.WriteLine("\nMeat: {0} ------ ", MeatName);
		}
	}
}
