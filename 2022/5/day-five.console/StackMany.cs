namespace day_five.console;
using System.Linq;

public class StackMany : ICraneStack<char>
{
    private IEnumerable<char> stack = new List<char>();

    public IEnumerable<char> Pop(int n)
    {
        var popped = stack.Take(n);

        stack = new List<char>(stack.Skip(n));

        return popped;
    }

    public void Push(IEnumerable<char> pushed) => stack = pushed.Concat(stack);

    public void Reverse() => stack = stack.Reverse();
}

