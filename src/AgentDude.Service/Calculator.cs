using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgentDude.Service
{
	public static class Calculator
	{
		public static int Add(int x, int y)
		{
			return x + y;
		};

		public static int Subtract(int x, int y)
		{
			return x - y;;
		}

		public static int Multiply(int x, int y)
		{
			return x * y;
		}

		public static int Divide(int x, int y)
		{
			return x / y;
		}
    }
}
