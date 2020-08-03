using System;

namespace Adapter
{
	class MeatDetails : Meat
	{
		private MeatDatabase _meatDatabase;

		public MeatDetails(string name): base(name)
		{
		}

		public override void LoadData()
		{
			// The Adaptee
			_meatDatabase = new MeatDatabase();

			SafeCookTempFahrenheit = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Fahrenheit);
			SafeCookTempCelsius = _meatDatabase.GetSafeCookTemp(MeatName, TemperatureType.Celsius);
			CaloriesPerOunce = _meatDatabase.GetCaloriesPerOunce(MeatName);
			ProteinPerOunce = _meatDatabase.GetProteinPerOunce(MeatName);

			base.LoadData();
			Console.WriteLine(" Safe Cook Temp (F): {0}", SafeCookTempFahrenheit);
			Console.WriteLine(" Safe Cook Temp (C): {0}", SafeCookTempCelsius);
			Console.WriteLine(" Calories per Ounce: {0}", CaloriesPerOunce);
			Console.WriteLine(" Protein per Ounce: {0}", ProteinPerOunce);
		}
	}
}
