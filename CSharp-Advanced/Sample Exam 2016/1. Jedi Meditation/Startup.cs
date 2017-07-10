using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Jedi_Meditation
{
	class Startup
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var masters = new List<string>();
			var knights = new List<string>();
			var padawans = new List<string>();
			var toshkoAndSlav = new List<string>();
			var toshko = "";
			var slav = "";
			var IsYodaThere = false;
			for (int i = 0; i < n; i++)
			{
				var jedis = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				foreach (var jedi in jedis)
				{
					if (jedi.Contains("m"))
					{
						masters.Add(jedi);
					}
					else if (jedi.Contains("k"))
					{
						knights.Add(jedi);
					}
					else if (jedi.Contains("p"))
					{
						padawans.Add(jedi);
					}
					else if (jedi.Contains("t"))
					{
						toshkoAndSlav.Add(jedi);
						toshko = jedi;
					}
					else if (jedi.Contains("s"))
					{
						toshkoAndSlav.Add(jedi);
						slav = jedi;
					}
					else if (jedi.Contains("y"))
					{
						IsYodaThere = true;
					}
				}
			}

			var allJedis = new List<string>();
			if (toshko == "" || slav == "")
			{
				allJedis.AddRange(masters.OrderBy(c=> c));
				allJedis.AddRange(knights.OrderBy(c=> c));
				allJedis.AddRange(padawans.OrderBy(c=> c));
			}
			else if (toshko != "" && slav != "" && !IsYodaThere )
			{
				allJedis.AddRange(toshkoAndSlav);
				allJedis.AddRange(masters);
				allJedis.AddRange(knights);
				allJedis.AddRange(padawans);
			}
			else if (toshko != "" && slav != "" && IsYodaThere)
			{
				allJedis.AddRange(masters);
				allJedis.AddRange(knights);
				allJedis.AddRange(toshkoAndSlav);
				allJedis.AddRange(padawans);
			}
			else if (toshko != "" && IsYodaThere == false || slav != "" && IsYodaThere == false)
			{
				if (toshko != "" && slav == "")
				{
					allJedis.Add(toshko);
					allJedis.AddRange(masters);
					allJedis.AddRange(knights);
					allJedis.AddRange(padawans);
				}
				else
				{
					allJedis.Add(slav);
					allJedis.AddRange(masters);
					allJedis.AddRange(knights);
					allJedis.AddRange(padawans);
				}
			}
			Console.WriteLine(string.Join(" ", allJedis));
		}
	}
}
