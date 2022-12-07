namespace day_five.console;

public static class LineExtensions
{
    public static LineCategory GetCategory(this string line)
    {
        if (line.Contains("["))
            return LineCategory.Crates;

        if (line.Contains("move"))
            return LineCategory.Instruction;

        if (string.IsNullOrWhiteSpace(line))
            return LineCategory.Empty;

        return LineCategory.Label;
    }
}

