using System.Collections.Generic;

namespace Command
{
	public abstract class OrderCommand
	{
		public abstract void Execute(List<MenuItem> order, MenuItem newItem);
	}
}
