using System;
using System.Collections.Generic;

namespace Observer
{
	/// <summary>
	/// The Subject abstract class
	/// </summary>
	abstract class Veggies
	{
		private double _pricePerPound;
		private List<IRestaurant> _restaurants = new List<IRestaurant>();

		public Veggies(double pricePerPound)
		{
			_pricePerPound = pricePerPound;
		}

		public void Attach(IRestaurant restaurant)
		{
			_restaurants.Add(restaurant);
		}

		public void Detach(IRestaurant restaurant)
		{
			_restaurants.Remove(restaurant);
		}

		public void Notify()
		{
			foreach (IRestaurant restaurant in _restaurants)
			{
				restaurant.Update(this);
			}

			Console.WriteLine("");
		}

		public double PricePerPound
		{
			get => _pricePerPound;
			set
			{
				if (_pricePerPound != value)
				{
					_pricePerPound = value;
					Notify();
				}
			}
		}
	}
}
