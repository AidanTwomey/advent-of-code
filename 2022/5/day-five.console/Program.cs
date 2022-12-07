// See https://aka.ms/new-console-template for more information
using day_five.console;

Console.WriteLine(CrateStacker.Execute(await File.ReadAllTextAsync(args[0]), Int32.Parse(args[1])));
