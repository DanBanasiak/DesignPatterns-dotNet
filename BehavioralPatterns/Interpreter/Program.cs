using System;
using System.Collections.Generic;

namespace Interpreter
{

	class Program
	{
		static void Main(string[] args)
		{
			string roman = null;
			while (!string.IsNullOrEmpty(roman = Console.ReadLine()))
			{
				var context = new Context(roman);

				var tree = new List<Expression>
				{
					new ThousandExpression(),
					new HundredExpression(),
					new TenExpression(),
					new OneExpression()
				};

				foreach (Expression exp in tree)
				{
					exp.Interpret(context);
				}

				Console.WriteLine("{0} = {1}", roman, context.Output);
			}

			Console.ReadKey();
		}
	}
}
