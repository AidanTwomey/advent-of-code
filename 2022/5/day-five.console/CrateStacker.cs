namespace day_five.console;
using System.Linq;

public class CrateStacker
{
    public static string Execute(string instructions, int version)
    {
        var (stacks, positions) = InitialiseStacks(instructions, version);

        foreach (var line in instructions.Split('\n'))
        {
            Action<string> action = line.GetCategory() switch
            {
                LineCategory.Crates      => AddCrates,
                LineCategory.Instruction => MoveCrate,
                LineCategory.Empty       => Reverse,
                _                        => Skip
            };

            action(line);
        }

        return String.Join("", stacks.SelectMany(q => q.Pop(1)));

        void Reverse(string line)
        {
            for (int i = 0; i < stacks.Length; ++i)
                stacks[i].Reverse();
        }

        void AddCrates(string line)
        {
            if (line.Contains('['))
            {
                foreach (var (crate, queue) in positions.Select(i => line[i]).Zip(stacks))
                    if (crate != ' ') queue.Push(new[] { crate });
            }
        }

        void MoveCrate(string line)
        {
            var instructions = Instructions.Parse(line);

            var lifted = stacks[instructions.from].Pop(instructions.count);
            stacks[instructions.to].Push(lifted);
        }

        void Skip(string line)
        {
        }
    }

    private static (ICraneStack<char>[], int[]) InitialiseStacks(string instructions, int version)
    {
        int len = (instructions.IndexOf('\n') + 1) / 4;

        var stacks = new ICraneStack<char>[len];
        var positions = new int[len];
        for (int i = 0; i < len; ++i)
        {
            stacks[i] = version == 9000 ? new StackOne() : new StackMany();
            positions[i] = (i * 4) + 1;
        }

        return (stacks, positions);
    }
}

