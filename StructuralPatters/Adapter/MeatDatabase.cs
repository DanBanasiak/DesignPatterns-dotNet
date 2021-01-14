namespace Adapter
{
	class MeatDatabase
	{
		// Temps from http://www.foodsafety.gov/keep/charts/mintemp.html
		public float GetSafeCookTemp(string meat, TemperatureType tempType)
		{
			if (tempType == TemperatureType.Fahrenheit)
			{
				switch (meat)
				{
					case "beef":
					case "pork":
						return 145f;

					case "chicken":
					case "turkey":
						return 165f;

					default:
						return 165f;
				}
			}
			else
			{
				switch (meat)
				{
					case "beef":
					case "veal":
					case "pork":
						return 63f;

					case "chicken":
					case "turkey":
						return 74f;

					default:
						return 74f;
				}
			}
		}

		public int GetCaloriesPerOunce(string meat)
		{
			return (meat.ToLower()) switch
			{
				"beef" => 71,
				"pork" => 69,
				"chicken" => 66,
				"turkey" => 38,
				_ => 0,
			};
		}

		public double GetProteinPerOunce(string meat)
		{
			return (meat.ToLower()) switch
			{
				"beef" => 7.33f,
				"pork" => 7.67f,
				"chicken" => 8.57f,
				"turkey" => 8.5f,
				_ => 0d,
			};
		}
	}
}
