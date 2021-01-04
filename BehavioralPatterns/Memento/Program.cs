using System;

namespace Memento
{
	class Program
	{
		static void Main(string[] args)
		{
			//Here's a new supplier for our restaurant
			var s = new FoodSupplier
			{
				Name = "Harold Karstark",
				Phone = "(482) 449-1172"
			};

			// Let's store that entry in our database.
			var m = new SupplierMemory
			{
				Memento = s.SaveMemento()
			};

			// Continue changing originator
			s.Address = "548 S Main St. Nowhere, KS";

			// Crap, gotta undo that entry, I entered the wrong address
			s.RestoreMemento(m.Memento);

			Console.ReadKey();
		}
	}
}