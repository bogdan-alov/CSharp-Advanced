using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _02.Book_Shop.Models;

namespace _02.Book_Shop
{
	class Startup
	{
		static void Main(string[] args)
		{
			try
			{
				string author = Console.ReadLine();
				string title = Console.ReadLine();
				decimal price = decimal.Parse(Console.ReadLine());

				Book book = new Book(author, title, price);
				GoldenEditionBook goldenEditionBook = new GoldenEditionBook(author, title, price);

				Console.WriteLine(book);
				Console.WriteLine(goldenEditionBook);
			}
			catch (Exception ae)
			{
				Console.WriteLine(ae.Message);
			}

		}
	}
}
