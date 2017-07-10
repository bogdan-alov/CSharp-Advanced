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
		static void Main(string[] args)
		{
			var input = Console.ReadLine();
			//var departments  = new Dictionary<string, List<string>>();
			//var patients = new Dictionary<string, List<string>>>();
			var pattern = "(\\w+)\\s(\\w+\\s\\w+)\\s(\\w+)";

			// department -> doctor -> room -> bed -> patient
			while (input != "Output")
			{
				//var match = Regex.Match(input, pattern);
				
				//var departmentName  = match.Groups[1].Value;
				//var doctor = match.Groups[2].Value;
				//var patient = match.Groups[2].Value;
	
				//if (!departments.ContainsKey(departmentName))
				//{
	
					
				//	departments.Add(departmentName, new List<string>());
				//	departments[departmentName].Add(doctor);
				//	patients.Add(doctor, new Dictionary<int, List<string>>());
				//	patients[doctor].Add(1, new List<string>());
				//	patients[doctor][1].Add(patient);
				//}
				//else
				//{
				//	if (!departments[departmentName].Contains(doctor))
				//	{
						
				//		departments[departmentName].Add(doctor);
				//		patients.Add(doctor, new Dictionary<int, List<string>>());
				//		patients[doctor].Add(1, new List<string>());
				//		patients[doctor][1].Add(patient);
				//	}
				//	else
				//	{
				//		if (!patients[doctor].C)
				//		{
				//			var last = patients[doctor].Keys.Last();
				//			if (patients[doctor][last].Contains(patient))
				//			{
								
				//			}
				//		}
						
				//	}
				//}
				input = Console.ReadLine();
			}

			input = Console.ReadLine();
			while (input != "End")
			{


				input = Console.ReadLine();
			}
		}
	
	}

}
