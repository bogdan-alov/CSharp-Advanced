using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem_08.Military_Force.Models;
using Problem_08.Military_Force.Models.Interfaces;

namespace Problem_08.Military_Force
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = "";
			var list = new List<Soldier>();
			while ((input = Console.ReadLine()) != "End")
			{
				try
				{
					var array = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
					if (array[0] == "Private")
					{
						var privateSoldier = new PrivateSoldier(array[1], array[2], array[3], double.Parse(array[4]));
						list.Add(privateSoldier);
					}
					else if (array[0] == "LeutenantGeneral")
					{
						if (array.Length > 5)
						{
							var soldiers = new SortedSet<PrivateSoldier>();
							for (int i = 5; i < array.Length; i++  )
							{
								var id = array[i];
								var privateSoldier = (PrivateSoldier)list.FirstOrDefault(c => c.Id.Equals(id));
								soldiers.Add(privateSoldier);
							}
							var leutenantGeneral = new LeutenantGeneral(array[1], array[2], array[3], double.Parse(array[4]),soldiers);
							list.Add(leutenantGeneral);
						}
						else
						{
							var leutenantGeneral = new LeutenantGeneral(array[1], array[2], array[3], double.Parse(array[4]), new SortedSet<PrivateSoldier>());
							list.Add(leutenantGeneral);
						}
					}
					else if (array[0] == "Engineer")
					{
						var engineer = new Engineer(array[1], array[2], array[3], double.Parse(array[4]), array[5]);
						if (array.Length> 6)
						{
							var name = "";
							var hours = 0;
							for (int i = 6; i < array.Length; i++)
							{
								if (int.TryParse(array[i], out int result))
								{
									hours = int.Parse(array[i]);

								}
								else
								{
									name = array[i];
								}

								if (name.Length > 0 && hours > 0)
								{
									engineer.Repairs.Add(new Repair(name, hours));
									name = "";
									hours = 0;
								}
							}

						}
						list.Add(engineer);
					}
					else if (array[0] == "Commando")
					{
						var commando = new Commando(array[1], array[2], array[3], double.Parse(array[4]), array[5]);
						if (array.Length > 6)
						{
							var name = "";
							var state = "";
							for (int i = 6; i < array.Length; i++)
							{
								if (i % 2 == 0)
								{
									name = array[i];

								}
								else
								{
									
										state = array[i];
									
								}

								if (name.Length > 0 && state.Length > 0)
								{
									if (state.Equals("Finished") || state.Equals("inProgress"))
									{
										commando.Missions.Add(new Mission(name, state));
									}
									
									name = "";
									state = "";
								}
							}

						}
						list.Add(commando);
					}
					else if (array[0] == "Spy")
					{
						var spy = new Spy(array[1], array[2], array[3], double.Parse(array[4]));
						list.Add(spy);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					continue;
					
				}
			}
			foreach (var soldier in list)
			{
				Console.WriteLine(soldier);
			}
		}
	}
}
