﻿namespace Command
{
	public class CommandFactory
	{
		public OrderCommand GetCommand(int commandOption)
		{
			switch (commandOption)
			{
				case 1:
					return new AddCommand();
				case 2:
					return new ModifyCommand();
				case 3:
					return new RemoveCommand();
				default:
					return new AddCommand();
			}
		}
	}
}
