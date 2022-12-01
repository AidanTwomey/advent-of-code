// See https://aka.ms/new-console-template for more information
using day_one.console;

Console.WriteLine(new CalorieCalculator().GetMostCalorific(
    Int32.Parse(args[0]), 
    PackParser.Parse(args[1])));
