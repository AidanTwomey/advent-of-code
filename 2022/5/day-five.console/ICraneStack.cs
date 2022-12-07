namespace day_five.console;

public interface ICraneStack<T>
{
    void Push(IEnumerable<char> pushed);
    IEnumerable<char> Pop(int n);
    void Reverse();
}

