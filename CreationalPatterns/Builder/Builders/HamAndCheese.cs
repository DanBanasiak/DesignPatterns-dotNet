namespace Builder.Builders
{
	class HamAndCheese : AbstractBuilder
	{
		public HamAndCheese()
		{
			sandwich = new Sandwich("Ham and Cheese");
		}

		public override void AddBread()
		{
			sandwich.Ingredients.Add("White");
		}

		public override void AddMeats()
		{
			sandwich.Ingredients.Add("Ham");
		}

		public override void AddCheese()
		{
			sandwich.Ingredients.Add("American");
		}

		public override void AddVeggies()
		{
		}

		public override void AddCondiments()
		{
			sandwich.Ingredients.Add("Mayo");
		}
	}
}
