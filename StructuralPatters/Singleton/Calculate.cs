namespace Singleton
{
	public sealed class Calculate
	{
		private Calculate()
		{
		}

		private static Calculate instance = null;

		public static Calculate Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Calculate();
				}

				return instance;
			}
		}

		public double ValueOne { get; set; }
		public double ValueTwo { get; set; }

		public double Addition() => ValueOne + ValueTwo;
		public double Subtraction() => ValueOne - ValueTwo;
		public double Multiplication() => ValueOne * ValueTwo;
		public double Division() => ValueOne / ValueTwo;
	}
}
