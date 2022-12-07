namespace day_five.console;
using System.Linq;
using System.Text.RegularExpressions;

public class Instructions
{

    private const string movePattern = @"move (\d+)";
    private const string fromPattern = "from (.+?)";
    private const string toPattern = "to (.+?)";
    private const string replacement = "$1";

    public static (int from, int to, int count) Parse(string line)
    {
        var move = Regex.Matches(line, movePattern).Single();
        var from = Regex.Matches(line, fromPattern).Single();
        var to = Regex.Matches(line, toPattern).Single();

        return new (
            Int32.Parse(from.Result(replacement))-1,
            Int32.Parse(to.Result(replacement))-1, 
            Int32.Parse(move.Result(replacement)));
    }
}

