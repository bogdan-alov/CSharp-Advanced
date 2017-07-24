
using System.Collections.Generic;
using System.Linq;

public class Box<T>
{

	public Box()
	{
		this.data = new List<T>();
	}

	private IList<T> data;
	public void Add(T element)
	{
		data.Add(element);
	}

	public int Count => this.data.Count;

	public T Remove()
	{
		var lastElement = data.LastOrDefault();
		this.data.RemoveAt(this.data.Count - 1);
		return lastElement;
	}
}

