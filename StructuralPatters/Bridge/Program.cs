﻿using Bridge.Abstraction;
using Bridge.ConcreteImplementor;
using Bridge.RefinedAbstraction;
using System;

namespace Bridge
{
	class Program
	{
		static void Main(string[] args)
		{
			SendOrder _sendOrder = new SendDairyFreeOrder();
			_sendOrder.Restaurant = new DinerOrders();
			_sendOrder.Send();

			_sendOrder.Restaurant = new FancyRestaurantOrders();
			_sendOrder.Send();

			_sendOrder = new SendGlutenFreeOrder();
			_sendOrder.Restaurant = new DinerOrders();
			_sendOrder.Send();

			_sendOrder.Restaurant = new FancyRestaurantOrders();
			_sendOrder.Send();

			Console.ReadKey();
		}
	}
}
