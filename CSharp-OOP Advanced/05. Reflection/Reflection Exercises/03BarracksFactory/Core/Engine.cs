using _03BarracksFactory.Core.Commands;

namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            string result = string.Empty;
            switch (commandName)
            {
                case "add":
                    result = new AddCommand(data, this.repository, this.unitFactory).Execute();
                    break;
                case "report":
					result = new ReportCommand(data, this.repository, this.unitFactory).Execute();
					break;
				case "retire":
					try
					{
						result = new RetireCommand(data, this.repository, this.unitFactory).Execute();
					}
					catch (Exception e)
					{
						result = e.Message;
					}
					break;
                case "fight":
                    Environment.Exit(0);
                    break;
                default:
                    throw new InvalidOperationException("Invalid command!");
            }
            return result;
        }

    }
}
