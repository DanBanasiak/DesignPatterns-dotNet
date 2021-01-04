using System;

namespace Memento
{
	class FoodSupplier
	{
		private string _name;
		private string _phone;
		private string _address;

		public string Name
		{
			get => _name;
			set
			{
				_name = value;
				Console.WriteLine("Proprietor:  " + _name);
			}
		}

		public string Phone
		{
			get => _phone;
			set
			{
				_phone = value;
				Console.WriteLine("Phone Number: " + _phone);
			}
		}

		public string Address
		{
			get => _address;
			set
			{
				_address = value;
				Console.WriteLine("Address: " + _address);
			}
		}

		public FoodSupplierMemento SaveMemento()
		{
			Console.WriteLine("\nSaving current state\n");
			return new FoodSupplierMemento(_name, _phone, _address);
		}

		public void RestoreMemento(FoodSupplierMemento memento)
		{
			Console.WriteLine("\nRestoring previous state\n");
			Name = memento.Name;
			Phone = memento.PhoneNumber;
			Address = memento.Address;
		}
	}
}