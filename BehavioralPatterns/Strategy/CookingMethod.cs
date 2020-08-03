using System;

namespace Strategy
{
	/// <summary>
	/// The Context class, which maintains a reference to the chosen Strategy.
	/// </summary>
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
