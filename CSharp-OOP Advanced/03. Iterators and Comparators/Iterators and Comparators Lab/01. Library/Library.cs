using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Library : IEnumerable<Book>
{
	private List<Book> books;

	public Library(params Book[] books)
	{
		this.books = new List<Book>(books);
	}

	public IEnumerator<Book> GetEnumerator()
	{
		return new LibraryIterator(books);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private class LibraryIterator : IEnumerator<Book>
	{
		public LibraryIterator(IEnumerable<Book> books)
		{
			Reset();
			this.books = new List<Book>(books).OrderBy(x => x, new BookComparator()).ToList(); 
		}
		private List<Book> books;
		private int currentIndex;
		

		public void Dispose()
		{
			
		}

		public bool MoveNext()
		{
			return ++currentIndex < this.books.Count;
		}

		public void Reset()
		{
			this.currentIndex = -1;
		}

		public Book Current
		{
			get { return this.books[currentIndex]; }
		}

		object IEnumerator.Current
		{
			get { return Current; }
		}
	}
}

