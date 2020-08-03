namespace Builder
{
	class Director
	{
		public void Assemble(AbstractBuilder sandwichBuilder)
		{
			sandwichBuilder.AddBread();
			sandwichBuilder.AddMeats();
			sandwichBuilder.AddCheese();
			sandwichBuilder.AddVeggies();
			sandwichBuilder.AddCondiments();
		}
	}
}
