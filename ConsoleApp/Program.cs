using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			string a = Convert.ToString(Console.ReadLine());
			int m = Convert.ToInt32(Console.ReadLine());
			int time = 0;
			string b = Convert.ToString(Console.ReadLine());
			string[] c = b.Split(' ');

			List<string> d = new List<string>();

			foreach (string s in c)
			{
				d.Add(s);
			}

			d.Add(a);
			d.Sort();

			int i = 0;

			if ((d.IndexOf(a) + 1) <= m)
			{
				time += 20;
			}
			else
			{
				do
				{
					if ((i + 1) - m >= 0)
					{
						time += 20;
					}
					i++;
				} while (i <= d.IndexOf(a));
			}
			Console.WriteLine(time);
			Console.ReadLine();
		}
	}
}

