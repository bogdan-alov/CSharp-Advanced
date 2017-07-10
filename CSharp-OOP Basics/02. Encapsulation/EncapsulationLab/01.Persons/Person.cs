
using System;

class Person
{
	private string firstName;
	private string lastName;
	private int age;
	private double salary;

	public Person(string firstName, string lastName, int age, double salary)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Age = age;
		this.Salary = salary;
	}

	public string FirstName
	{
		get { return this.firstName; }
		set
		{
			if (value.Length < 3)
			{
				throw new ArgumentException("First name cannot be less than 3 symbols");
			}
			this.firstName = value;

		}
	}

	public string LastName
	{
		get { return this.lastName; }
		set
		{
			if (value.Length < 3)
			{
				throw new ArgumentException("Last name cannot be less than 3 symbols");
			}
			this.lastName = value;

		}
	}

	public int Age
	{
		get { return this.age; }
		set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Äge cannot be zero or negative number");
			}
			this.age = value;
		}
	}

	public double Salary
	{
		get { return this.salary; }
		set
		{
			if (value < 460.0d)
			{
				throw new ArgumentException("Salary cannot be less then 460 leva");
			}
			this.salary = value;
		}
	}
	public void IncreaseSalary(double bonus)
	{
		if (age < 30)
		{
			bonus = bonus / 2;
			salary += salary * (bonus / 100);
		}
		else
		{
			salary += salary * (bonus / 100);
		}
	}
	public override string ToString()
	{
		return $"{firstName} {lastName} get {salary:f2} leva";
	}
}

