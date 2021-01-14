using System;

namespace TemplateMethod
{
	abstract class AbstractBread
	{
		public abstract void MixIngredients();

		public abstract void Bake();

		public void Slice()
		{
			Console.WriteLine("Slicing the " + GetType().Name + " bread!");
		}

		public void Make()
		{
			MixIngredients();
			Bake();
			Slice();
		}
	}
}
