﻿using System.Collections.Generic;
using System.Linq;

namespace Command
{
	public class RemoveCommand : OrderCommand
	{
		public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
		{
			currentItems.Remove(currentItems.Where(x => x.Name == newItem.Name).First());
		}
	}
}
