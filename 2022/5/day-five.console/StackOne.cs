namespace day_five.console;
using System.Linq;

public class StackOne : ICraneStack<char>
{
    private Stack<char> stack = new Stack<char>();

    public IEnumerable<char> Pop(int n)
    {
        for (int i = 0; i < n; ++i)
            yield return stack.Pop();
    }

    public void Push(IEnumerable<char> pushed)
    {
        foreach (var p in pushed)
            stack.Push(p);
    }

    public void Reverse()
    {
        var copy = new Stack<char>();

        while (stack.Any())
            copy.Push(stack.Pop());

        stack = copy;
    }
}

