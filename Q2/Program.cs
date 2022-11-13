using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IEnumerable<int> list = Enumerable.Range(10, 6);
			foreach(int i in list)
			{
				Console.WriteLine(i);
			}
		}
	}
}
