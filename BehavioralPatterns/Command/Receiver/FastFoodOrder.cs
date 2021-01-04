using System;
using System.Collections.Generic;

namespace Command
{
	public class FastFoodOrder
	{
		public List<MenuItem> currentItems { get; set; }
		public FastFoodOrder()
		{
			currentItems = new List<MenuItem>();
		}

		public void ExecuteCommand(OrderCommand command, MenuItem item)
		{
			command.Execute(currentItems, item);
		}

		public void ShowCurrentItems()
		{
			foreach (var item in currentItems)
			{
				item.Display();
			}
			Console.WriteLine("-----------------------");
		}

	}
}
