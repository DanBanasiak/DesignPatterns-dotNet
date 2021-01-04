using System.Collections.Generic;

namespace Command
{
	public class AddCommand : OrderCommand
	{
		public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
		{
			currentItems.Add(newItem);
		}
	}
}
