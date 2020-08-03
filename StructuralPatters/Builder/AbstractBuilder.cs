namespace Builder
{
	abstract class AbstractBuilder
	{
		protected Sandwich sandwich;

		public Sandwich Sandwich => sandwich;

		public abstract void AddBread();
		public abstract void AddMeats();
		public abstract void AddCheese();
		public abstract void AddVeggies();
		public abstract void AddCondiments();
	}
}
