using System.Reflection;

namespace _02BlackBoxInteger
{
    using System;

    class BlackBoxIntegerTests
    {
        static void Main(string[] args)
        {
            //TODO write your solution of Problem 2. Black Box Integer here
	        var input = "";
	        var type = typeof(BlackBoxInt);
	        ConstructorInfo ctorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, new[] { typeof(int) }, null);
	        var blackBox = (BlackBoxInt) ctorInfo.Invoke(new object[] {0});
			while ((input = Console.ReadLine()) != "END")
			{
				var cmdArgs = input.Split(new char[] {'_'}, StringSplitOptions.RemoveEmptyEntries);
		        var number = int.Parse(cmdArgs[1]);
				var methodName = cmdArgs[0];
		        MethodInfo method = type.GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);
		        method.Invoke(blackBox, new object[] { number });
				Console.WriteLine(type.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(blackBox));
			}

        }
    }
}
