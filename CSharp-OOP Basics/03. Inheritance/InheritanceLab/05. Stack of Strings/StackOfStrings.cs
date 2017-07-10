using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StackOfStrings : List<string>
{
	private List<string> data;

	public StackOfStrings()
	{
		data = this;
	}

	public void Push(string str)
	{
		data.Add(str);
	}

	public string Pop()
	{

		try
		{
			var last = this.data.Last();
			this.data.Remove(last);
			return last;
		}
		catch (Exception)
		{
			throw new Exception("No data in the object.");
		}
	}


}

