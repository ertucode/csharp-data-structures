namespace DataStructures;

public class Stack<T>
{
    public uint Length { private set; get; } = 0;

    private PNode<T>? _top;

    public void Push(T item)
    {
        var node = new PNode<T>(item);
        Length++;
        if (_top == null)
        {
            _top = node;
            return;
        }

        node.Prev = _top;
        _top = node;
    }

    public T? Pop()
    {
        if (_top == null)
            return default;

        Length--;
        var topVal = _top.Value;

        _top = _top.Prev;

        return topVal;
    }

    public T? Peek()
    {
        if (_top != null)
            return _top.Value;
        return default;
    }
}
