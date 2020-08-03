﻿using System;

namespace TemplateMethod
{
	class WholeWheat : AbstractBread
	{
		public override void MixIngredients()
		{
			Console.WriteLine("Gathering Ingredients for Whole Wheat Bread.");
		}

		public override void Bake()
		{
			Console.WriteLine("Baking the Whole Wheat Bread. (15 minutes)");
		}
	}
}
