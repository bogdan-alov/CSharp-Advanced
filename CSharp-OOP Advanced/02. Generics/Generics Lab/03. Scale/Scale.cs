
using System;

public class Scale<T>
	where T : IComparable
{
	private T right;
	private T left;

	public T GetHavier()
	{
		if (right.CompareTo(left) > 0)
		{
			return right;
		}
		else if (right.CompareTo(left) < 0)
		{
			return left;
		}

		return default(T);
	}

	public Scale(T right, T left)
	{
		this.right = right;
		this.left = left;
	}
}

