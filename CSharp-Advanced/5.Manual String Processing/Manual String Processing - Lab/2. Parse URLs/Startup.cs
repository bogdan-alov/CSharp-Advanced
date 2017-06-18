using System;
using System.Linq;

namespace _2.Parse_URLs
{
    class Startup
    {
        static void Main(string[] args)
        {
	        var url = Console.ReadLine();

	        var protocol = "";
	        var server = "";
	        var resources = "";
	        var tokens = url.Split(new string[] {"://"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
	        if (tokens.Length != 2 || tokens[1].IndexOf('/') == -1)
	        {
		        Console.WriteLine("Invalid URL");
		        return;
	        }
	        else
	        {
		        protocol = tokens[0];
		      
				server = tokens[1].Substring(0, tokens[1].IndexOf('/'));
		        resources = tokens[1].Substring(tokens[1].IndexOf('/') + 1);
		        Console.WriteLine($"Protocol = {protocol}");
		        Console.WriteLine($"Server = {server}");
				Console.WriteLine($"Resources = {resources}");
	        }
        }
    }
}