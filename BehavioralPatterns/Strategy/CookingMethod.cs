using System;

namespace Strategy
{
	class CookingMethod
	{
		private string Food;
		private AbstractCook _cookStrategy;

		public void SetCookStrategy(AbstractCook cookStrategy)
		{
			_cookStrategy = cookStrategy;
		}

		public void SetFood(string name)
		{
			Food = name;
		}

		public void Cook()
		{
			_cookStrategy.Cook(Food);
			Console.WriteLine();
		}
	}
}
