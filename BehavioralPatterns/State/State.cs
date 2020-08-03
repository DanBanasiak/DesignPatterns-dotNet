namespace State
{
	abstract class State
	{
		protected Steak steak;
		protected double currentTemp;
		protected double lowerTemp;
		protected double upperTemp;
		protected bool canEat;

		public Steak Steak
		{
			get => steak;
			set => steak = value;
		}

		public double CurrentTemp
		{
			get => currentTemp;
			set => currentTemp = value;
		}

		public abstract void AddTemp(double temp);
		public abstract void RemoveTemp(double temp);
		public abstract void DonenessCheck();
	}
}
