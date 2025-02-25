﻿namespace State
{
	class MediumRare : State
	{
		public MediumRare(State state) : this(state.CurrentTemp, state.Steak)
		{
		}

		public MediumRare(double currentTemp, Steak steak)
		{
			this.currentTemp = currentTemp;
			this.steak = steak;
			canEat = true;
			Initialize();
		}

		private void Initialize()
		{
			lowerTemp = 140;
			upperTemp = 154.9999999999;
		}

		public override void AddTemp(double amount)
		{
			currentTemp += amount;
			DonenessCheck();
		}

		public override void RemoveTemp(double amount)
		{
			currentTemp -= amount;
			DonenessCheck();
		}

		public override void DonenessCheck()
		{
			if (currentTemp < 0.0)
			{
				steak.State = new Uncooked(this);
			}
			else if (currentTemp < lowerTemp)
			{
				steak.State = new Rare(this);
			}
			else if (currentTemp > upperTemp)
			{
				steak.State = new Medium(this);
			}
		}
	}
}