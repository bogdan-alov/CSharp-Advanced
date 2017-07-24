
using System.Collections.Generic;

public class ProviderFactory
{
	public static Provider Register(List<string> arguments)
	{


		return new Provider("", 12);
	}


	public static Provider Check(List<string> arguments)
	{
		
		var provider = new Provider("", 12);
		return provider;
	}
}

