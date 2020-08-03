using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Non-adapted
			var unknown = new Meat("Beef");
			unknown.LoadData();

			//Adapted
			var beef = new MeatDetails("Beef");
			beef.LoadData();

			var turkey = new MeatDetails("Turkey");
			turkey.LoadData();

			var chicken = new MeatDetails("Chicken");
			chicken.LoadData();

			Console.ReadKey();
		}
	}
}
