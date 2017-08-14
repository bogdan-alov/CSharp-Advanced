using System.Reflection;

namespace _01HarestingFields
{
    using System;

    class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            //TODO put your reflection code here

	        var input = "";
	        Type type = typeof(HarvestingFields);
	        var fields = type.GetFields(
		        BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
			while ((input = Console.ReadLine()) != "HARVEST")
	        {
		        if (input == "private")
		        {
			        foreach (var fieldInfo in fields)
			        {
				        if (fieldInfo.IsPrivate)
				        {
					        Console.WriteLine("private {0} {1}", fieldInfo.FieldType.Name, fieldInfo.Name);
						}
			        }

		        }
				else if (input == "public")
		        {
					foreach (var fieldInfo in fields)
					{
						if (fieldInfo.IsPublic)
						{
							Console.WriteLine("public {0} {1}", fieldInfo.FieldType.Name, fieldInfo.Name);
						}
					}
				}
				else if (input == "protected")
		        {
					foreach (var fieldInfo in fields)
					{
						if (fieldInfo.IsFamily)
						{
							Console.WriteLine("protected {0} {1}", fieldInfo.FieldType.Name, fieldInfo.Name);
						}
					}
				}
				else if (input == "all")
		        {
					foreach (var fieldInfo in fields)
					{
						if (fieldInfo.IsFamily)
						{
							Console.WriteLine("protected {0} {1}", fieldInfo.FieldType.Name, fieldInfo.Name);
						}
						else if (fieldInfo.IsPublic)
						{
							Console.WriteLine("public {0} {1}", fieldInfo.FieldType.Name, fieldInfo.Name);
						}
						else if (fieldInfo.IsPrivate)
						{
							Console.WriteLine("private {0} {1}", fieldInfo.FieldType.Name, fieldInfo.Name);
						}
					}
				}
	        }
        }
    }
}
