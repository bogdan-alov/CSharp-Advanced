using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Hospital
{
	class Startup
	{
		static void Main()
		{
			var departments = new List<Department>();
			var doctors = new List<Doctor>();
			var input = String.Empty;
			
			// Initialization
			while ((input = Console.ReadLine()) != "Output")
			{
				var args = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();


				var departmentName = args[0];
				var doctorName = args[1] + " " + args[2];
				var patient = args[3];

				if (!doctors.Any(c => c.Name == doctorName))
				{
					doctors.Add(new Doctor(doctorName));
				}


				if (!departments.Any(c=> c.Name == departmentName))
				{
					var department = new Department(departmentName);
					var isSet = false;
					foreach (var departmentRoom in department.Rooms)
					{
						if (isSet)
						{
							break;
						}
						for (int i = 0; i < departmentRoom.Beds.Count; i++)
						{
							if (string.IsNullOrEmpty(departmentRoom.Beds[i]))
							{
								departmentRoom.Beds[i] = patient;
								doctors.FirstOrDefault(c => c.Name == doctorName).Patients.Add(patient);
								isSet = true;
								break;
							}
						}
					}
					departments.Add(department);
				}
				else
				{
					var department = departments.FirstOrDefault(c =>  c.Name == departmentName);
					var isSet = false;
					for (int i = 0; i < department.Rooms.Count; i++)
					{
						if (isSet)
						{
							break;
						}
						var room = department.Rooms[i];
						for (int j = 0; j < room.Beds.Count; j++)
						{
							if (string.IsNullOrEmpty(room.Beds[j]))
							{
								departments.FirstOrDefault(c => c.Name == departmentName).Rooms[i].Beds[j] =
									patient;
								doctors.FirstOrDefault(c=> c.Name == doctorName).Patients.Add(patient);
								isSet = true;
								break;
							}
						}
					}
				}
			}
			// Commands
			while ((input = Console.ReadLine()) != "End")
			{
				var arr = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
				if (arr.Length == 2)
				{
					if (int.TryParse(arr[1], out int room))
					{
						var beds = departments.FirstOrDefault(c => c.Name == arr[0]).Rooms[room - 1].Beds.OrderBy(c=> c);
						foreach (var bed in beds)
						{
							if (!string.IsNullOrEmpty(bed))
							{
								Console.WriteLine(bed);
							}
						}
					}
					else
					{
						var patients = doctors.FirstOrDefault(c => c.Name == arr[0] + " " + arr[1]).Patients.OrderBy(c=> c);
						foreach (var doctorPatient in patients)
						{
							Console.WriteLine(doctorPatient);
						}
					}
				}
				else
				{
					var department = departments.FirstOrDefault(c => c.Name == arr[0]);
					foreach (var departmentRoom in department.Rooms)
					{
						foreach (var departmentRoomBed in departmentRoom.Beds)
						{
							if (!string.IsNullOrEmpty(departmentRoomBed))
							{
								Console.WriteLine(departmentRoomBed);
							}
						}
					}
				}
			}

		}
	
	}

	class Doctor
	{
		public Doctor(string name)
		{
			this.Name = name;
			this.Patients = new List<string>();
		}

		public string Name { get; set; }

		public IList<string> Patients { get; set; }
	}

	class Department
	{
		public Department(string name)
		{
			this.Name = name;
			this.Rooms = new List<Room>(20);
			FillUpRooms();
		}
		public string Name { get; set; }

		public List<Room> Rooms { get; set; }


		private void FillUpRooms()
		{
			for (int i = 0; i < 20; i++)
			{
				Rooms.Add(new Room());
			}
		}
	}

	class Room
	{
		public Room()
		{
			this.Beds = new List<string>(3);
			FillUpBeds();
		}
		public List<string> Beds { get; set; }

		private void FillUpBeds()
		{
			for (int i = 0; i < 3; i++)
			{
				Beds.Add("");
			}
		}
	}
}
