using System;

namespace Zork
{
    enum Commands
    {
        QUIT,
        LOOK,
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UNKNOWN
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine();
            Commands command = ToCommand(inputString.Trim().ToUpper());
            Console.WriteLine(command);
        }
        private static Commands ToCommand(string commandString)
        {
            Commands command;
            switch (commandString)
            {
                case "QUIT":
                    command = Commands.QUIT;
                    break;

                case "LOOK":
                    command = Commands.LOOK;
                    break;

                case "NORTH":
                    command = Commands.NORTH;
                    break;

                case "SOUTH":
                    command = Commands.SOUTH;
                    break;

                case "EAST":
                    command = Commands.EAST;
                    break;
                case "WEST":
                    command = Commands.WEST;
                    break;

                default:
                    command = Commands.UNKNOWN;
                    break;
            };

            return command;
        }
        private static Commands ToCommands(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}