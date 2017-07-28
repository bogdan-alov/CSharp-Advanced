using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class WeeklyCalendar
{
	public WeeklyCalendar()
	{
		this.data = new List<WeeklyEntry>();
	}
	private IList<WeeklyEntry> data;

	public IEnumerable<WeeklyEntry> WeeklySchedule
	{
		get { return this.data; }
	}

	public void AddEntry(string weekDay, string notes)
	{
		var entry = new WeeklyEntry(weekDay, notes);
		this.data.Add(entry);
	}
}

