using System;

using System.Linq;


public class Program
	{
		public static void Main(string[] args)
		{
			WeeklyCalendar calendar = new WeeklyCalendar();
			calendar.AddEntry("Monday", "Internal Meeting");
			calendar.AddEntry("Tuesday", "Party");
			calendar.AddEntry("Wednesday", "Liga");
			calendar.AddEntry("Thursday", "Enum Lecture");
			calendar.AddEntry("Friday", "Ready for take-off");
			var ordered = calendar.WeeklySchedule.OrderBy(n=> n).ToList();
			foreach (var weeklyEntry in ordered)
			{
				Console.WriteLine(weeklyEntry);
			}
}
	}
