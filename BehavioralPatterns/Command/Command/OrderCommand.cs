﻿using System.Collections.Generic;

namespace Command
{
	/// <summary>
	/// The Command abstract class
	/// </summary>
	public abstract class OrderCommand
	{
		public abstract void Execute(List<MenuItem> order, MenuItem newItem);
	}
}
