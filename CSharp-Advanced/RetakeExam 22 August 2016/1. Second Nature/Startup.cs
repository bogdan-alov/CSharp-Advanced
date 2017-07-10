using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Second_Nature
{
	class Startup
	{
		static void Main(string[] args)
		{
			var flowers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray();

			var queue = new Queue<int>(flowers);

			var buckets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
				.ToArray();
			var stack = new Stack<int>(buckets);
			var bloomedFlowers = new Queue<int>();
			var queueSum = queue.Sum();
			var stackSum = stack.Sum();
			for (int i = 0; i < flowers.Length; i++)
			{

				if (stack.Count == 0)
				{
					break;
				}
				var firstFlower = queue.Peek();
				var lastBucket = stack.Pop();
				if (queueSum > stackSum && stack.Count != 0)
				{
					if (firstFlower > lastBucket)
					{
						firstFlower -= lastBucket;
						if (stack.Count == 0)
						{
							queue.Dequeue();
							queue.Enqueue(firstFlower);
						}

						while (stack.Count != 0)
						{
							lastBucket = stack.Pop();
							var difference = firstFlower - lastBucket;
							if (firstFlower == lastBucket)
							{
								bloomedFlowers.Enqueue(firstFlower);
							}
							else if (difference > 0)
							{
								queue.Dequeue();
								queue.Enqueue(difference);
								var array = queue.Reverse().ToArray();
								queue = new Queue<int>(array);
							}
							else if (difference <= 0)
							{
								queue.Dequeue();
								stack.Push(stack.Pop() + Math.Abs(difference));
								break;
							}
						}

					}
					else if (firstFlower == lastBucket)
					{
						bloomedFlowers.Enqueue(firstFlower);
						queue.Dequeue();
					}
					else
					{
						var difference = lastBucket - firstFlower;
						if (stack.Count == 0)
						{
							stack.Push(difference);
							queue.Dequeue();
						}
						else
						{
							stack.Push(stack.Pop() + difference);
							queue.Dequeue();
						}

					}
				}
				else
				{
					if (firstFlower > lastBucket)
					{
						firstFlower -= lastBucket;
						if (stack.Count == 0)
						{
							queue.Dequeue();
							queue.Enqueue(firstFlower);
						}
						while (stack.Count != 0)
						{
							lastBucket = stack.Pop();
							var difference = firstFlower - lastBucket;
							if (firstFlower == lastBucket)
							{
								bloomedFlowers.Enqueue(firstFlower);
							}
							else if (difference > 0)
							{
								queue.Dequeue();
								queue.Enqueue(difference);
								var array = queue.Reverse().ToArray();
								queue = new Queue<int>(array);
							}
							else if (difference <= 0)
							{
								queue.Dequeue();
								stack.Push(stack.Pop() + Math.Abs(difference));
								break;
							}
						}

					}
					else if (firstFlower == lastBucket)
					{
						bloomedFlowers.Enqueue(firstFlower);
						queue.Dequeue();
					}
					else
					{
						var difference = lastBucket - firstFlower;
						if (stack.Count == 0)
						{
							stack.Push(difference);
							queue.Dequeue();
						}
						else
						{
							
							stack.Push(stack.Pop() + difference);
							queue.Dequeue();
						}

					}
				}


			}
			var list = new List<int>();
			
			list.AddRange(stack);
			list.AddRange(queue);
			Console.WriteLine(string.Join(" ", list));
			if (bloomedFlowers.Count == 0)
			{
				Console.WriteLine("None");
			}
			else
			{
				Console.WriteLine(string.Join(" ", bloomedFlowers));
			}
		}
	}
}
