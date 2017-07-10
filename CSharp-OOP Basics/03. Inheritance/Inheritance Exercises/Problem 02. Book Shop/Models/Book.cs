using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Book_Shop.Models
{
	public class Book
	{
		private string title;
		private string author;
		private decimal price;

		public Book(string author, string title, decimal price)
		{
			this.Title = title;
			this.Author = author;
			this.Price = price;
		}

		public string Title
		{
			get { return this.title; }
			set
			{
				if (value.Length < 3)
				{
					throw new Exception("Title not valid!");
				}
				this.title = value;
			}
		}


		public string Author
		{
			get { return this.author; }
			set
			{
				var tokens = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				if (tokens.Length > 1)
				{
					if (char.IsDigit(tokens[1][0]))
					{
						throw new ArgumentException("Author not valid!");
					}
				}
				this.author = value;
			}
		}

		public virtual decimal Price
		{
			get { return this.price; }
			protected set
			{
				if (value <= 0)
				{
					throw new Exception("Price not valid!");
				}
				this.price = value;
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("Type: ").AppendLine(this.GetType().Name)
				.Append("Title: ").AppendLine(this.Title)
				.Append("Author: ").AppendLine(this.Author)
				.Append("Price: ").Append($"{this.Price:f1}")
				.AppendLine();

			return sb.ToString();

		}
	}
}
