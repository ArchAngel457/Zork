//TODO: Uncomment the lines below to get intellisense
//#r "D:\Development\Bitbucket\ucf-game-design-tools-plugins\Source Code\ZorkProgression\14_CommandScripting\bin\Debug\netcoreapp2.1\14_CommandScripting.dll"
//#r "System.Runtime.dll"
//#r "System.Runtime.Extensions.dll"

using System;
using Zork;

string[] responses = new string[]
{
    "Good day.",
    "Nice weather we've been having lately.",
    "Nice to see you."
};

var command = new Command("HELLO", new string[] { "HELLO", "HI", "HOWDY" },
    (game, commandContext) =>
    {
        string selectedResponse = responses[Game.Random.Next(responses.Length)];
        Console.WriteLine(selectedResponse);
    });

Game.Instance.CommandManager.AddCommand(command);