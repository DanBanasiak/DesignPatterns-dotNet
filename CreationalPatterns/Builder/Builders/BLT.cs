namespace Builder.Builders
{
	class BLT : AbstractBuilder
	{
		public BLT()
		{
			sandwich = new Sandwich("BLT");
		}

		public override void AddBread()
		{
			sandwich.Ingredients.Add("Bread");
		}

		public override void AddMeats()
		{
			sandwich.Ingredients.Add("Bacon");
		}

		public override void AddCheese()
		{
			sandwich.Ingredients.Add("Yello cheese");
		}

		public override void AddVeggies()
		{
			sandwich.Ingredients.Add("Tomato");
			sandwich.Ingredients.Add("Lettuce");
		}

		public override void AddCondiments()
		{
			sandwich.Ingredients.Add("Mayo");
			sandwich.Ingredients.Add("Mustard");
		}
	}
}
