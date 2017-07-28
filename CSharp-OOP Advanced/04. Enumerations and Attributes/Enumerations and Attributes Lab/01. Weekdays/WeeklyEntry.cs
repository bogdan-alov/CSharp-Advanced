
using System;

public class WeeklyEntry: IComparable<WeeklyEntry>
{
	public WeeklyEntry(string weekDay, string notes)
	{
		WeekDay = (WeekDay)Enum.Parse(typeof(WeekDay), weekDay);
		Notes = notes;
	}
	public WeekDay WeekDay { get; private set; }
	public string Notes { get; private set; }


	public int CompareTo(WeeklyEntry other)
	{
		if (ReferenceEquals(this, other)) return 0;
		if (ReferenceEquals(null, other)) return 1;
		var weekDayComparison = WeekDay.CompareTo(other.WeekDay);
		if (weekDayComparison != 0) return weekDayComparison;
		return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
	}

	public override string ToString()
	{
		return $"{WeekDay} - {Notes}";
	}
}

