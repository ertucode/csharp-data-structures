namespace DataStructures;

public class Queue<T>
{
    private uint _length = 0;

    private NNode<T>? _head;
    private NNode<T>? _tail;

    public void Enqueue(T item)
    {
        var toBeInserted = new NNode<T>(item);
        _length++;

        if (_head == null)
        {
            _tail = _head = toBeInserted;
            return;
        }
        if (_head == _tail)
        {
            var prevHead = _head;
            _head = toBeInserted;
            _tail = prevHead;
            _head.Next = _tail;
            return;
        }

        toBeInserted.Next = _head;
        _head = toBeInserted;
    }

    public T? Dequeue()
    {
        if (_head == null)
            return default;

        if (_head.Next == null)
        {
            _length = 0;
            var temp = _head;
            _head = _tail = null;
            return temp.Value;
        }

        var val = _head.Value;
        _head = _head.Next;
        _length--;

        return val;
    }

    public T? Peek()
    {
        if (_head != null)
            return _head.Value;
        return default;
    }
}
