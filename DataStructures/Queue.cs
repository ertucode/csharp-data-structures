namespace DataStructures;

public class Queue<T>
{
    public uint Length { private set; get; } = 0;

    private NNode<T>? _head;
    private NNode<T>? _tail;

    public void Enqueue(T item)
    {
        var toBeInserted = new NNode<T>(item);
        Length++;

        if (_tail == null)
        {
            _tail = _head = toBeInserted;
            return;
        }
        _tail.Next = toBeInserted;
        _tail = toBeInserted;
    }

    public T? Dequeue()
    {
        if (_head == null)
            return default;

        if (_head.Next == null)
        {
            Length = 0;
            var temp = _head;
            _head = _tail = null;
            return temp.Value;
        }

        var val = _head.Value;
        _head = _head.Next;
        Length--;

        return val;
    }

    public T? Peek()
    {
        if (_head != null)
            return _head.Value;
        return default;
    }
}
