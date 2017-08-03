using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.ListyIterator
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = "";
			var listyIterator = new ListyIterator<string>();
			while ((input = Console.ReadLine()) != "END")
			{
				var cmdArgs = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
				if (cmdArgs[0] == "Create")
				{
					if (cmdArgs.Length > 1)
					{
						listyIterator = new ListyIterator<string>(cmdArgs.Skip(1).ToArray());
					}
				}
				else if (cmdArgs[0] == "HasNext")
				{
					Console.WriteLine(listyIterator.HasNext());
				}
				else if (cmdArgs[0] == "Move")
				{
					Console.WriteLine(listyIterator.MoveNext());
				}
				else if (cmdArgs[0] == "Print")
				{
					try
					{
						Console.WriteLine(listyIterator.Print());
					}
					catch (Exception e)
					{
						Console.WriteLine(e.Message);
						
					}
				}
				else if (cmdArgs[0] == "PrintAll")
				{
					listyIterator.PrintAll();
				}
				

			}


		}
	}
}
