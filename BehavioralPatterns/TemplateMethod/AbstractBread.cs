using System;

namespace TemplateMethod
{
	/// <summary>
	/// The AbstractClass which contains the template method.
	/// </summary>
	abstract class AbstractBread
	{
		public abstract void MixIngredients();

		public abstract void Bake();

		public void Slice()
		{
			Console.WriteLine("Slicing the " + GetType().Name + " bread!");
		}

		// The template method
		public void Make()
		{
			MixIngredients();
			Bake();
			Slice();
		}
	}
}
