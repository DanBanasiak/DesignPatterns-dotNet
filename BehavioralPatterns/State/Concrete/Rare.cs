﻿namespace State
{
	class Rare : State
	{
		public Rare(State state) : this(state.CurrentTemp, state.Steak)
		{
		}

		public Rare(double currentTemp, Steak steak)
		{
			this.currentTemp = currentTemp;
			this.steak = steak;
			Initialize();
		}

		private void Initialize()
		{
			lowerTemp = 130;
			upperTemp = 139.999999999999;
			canEat = true;
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
			if (currentTemp < lowerTemp)
			{
				steak.State = new Uncooked(this);
			}
			else if (currentTemp > upperTemp)
			{
				steak.State = new MediumRare(this);
			}
		}
	}
}
