using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


public class Spy
{
	public string StealFieldInfo(string investigatedClass, params string[] fieldsToGet)
	{
		Type type = Type.GetType(investigatedClass);
		var fields = type.GetFields(
			BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Public);
		var sb = new StringBuilder();

		Object classInstance = Activator.CreateInstance(type, new object[] { });
		sb.AppendLine($"Class under investigation: {investigatedClass}");
		foreach (var fieldInfo in fields.Where(c => fieldsToGet.Contains(c.Name)))
		{
			sb.AppendLine($"{fieldInfo.Name} = {fieldInfo.GetValue(classInstance)}");
		}

		return sb.ToString();
	}

	public string AnalyzeAcessModifiers(string className)
	{
		var classType = Type.GetType(className);

		var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public);
		var sb = new StringBuilder();
		foreach (var fieldInfo in fields)
		{

			sb.AppendLine($"{fieldInfo.Name} must be private!");

		}

		var propertyAccessors = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

		foreach (var propertyAccessor in propertyAccessors.Where(c => c.Name.StartsWith("get")))
		{

			sb.AppendLine($"{propertyAccessor.Name} have to be public!");

		}

		var propertySetters = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
		foreach (var propertyAccessor in propertySetters.Where(c => c.Name.StartsWith("set")))
		{
			sb.AppendLine($"{propertyAccessor.Name} have to be private!");
		}

		return sb.ToString().Trim();
	}

	public string RevealPrivateMethods(string className)
	{
		var classType = Type.GetType(className);

		var sb = new StringBuilder();
		sb.AppendLine($"All private methods for class: {className}");

		var privates = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

		sb.AppendLine($"Base Class: {classType.BaseType.Name}");

		foreach (var methodInfo in privates)
		{
			sb.AppendLine(methodInfo.Name);
		}

		return sb.ToString().Trim();
	}

	public string CollectGettersAndSetters(string className)
	{
		var classType = Type.GetType(className);

		var sb = new StringBuilder();

		var getters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(c => c.Name.StartsWith("get"));
		var setters = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).Where(c => c.Name.StartsWith("set"));

		foreach (var methodInfo in getters)
		{
			sb.AppendLine($"{methodInfo.Name} is returning {methodInfo.ReturnType}");
		}

		foreach (var methodInfo in setters)
		{
			sb.AppendLine($"{methodInfo.Name} is returning {methodInfo.ReturnType}");
		}
		return sb.ToString().Trim();
	}
}

