using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Student_s_results
{
    class Startup
    {
        static void Main(string[] args)
        {
	        var n = int.Parse(Console.ReadLine());
			var dictionary = new Dictionary<string,double[]>();
	        for (int i = 0; i < n; i++)
	        {
		        var input = Console.ReadLine();
		        var takeNameAndGrades = input.Split(new []{'-'},StringSplitOptions.RemoveEmptyEntries).ToArray();
		        var name = takeNameAndGrades[0];
				var grades = takeNameAndGrades[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
		        dictionary.Add(name,grades);

	        }

	        Console.WriteLine(string.Format("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|", "Name", "CAdv", "COOP", "AdvOOP", "Average"));
	        foreach (var person in dictionary)
	        {
		        var average = (person.Value[0] + person.Value[1] + person.Value[2]) / person.Value.Length; 
		        Console.WriteLine("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",person.Key,person.Value[0], person.Value[1], person.Value[2], average);
				
	        }
        }
    }
}