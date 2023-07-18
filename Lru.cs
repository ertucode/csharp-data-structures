namespace DataStructures;

class Lru<K, V> where K : notnull
{
    private int _length = 0;
    private DoublyNode<V>? head = null;
    private DoublyNode<V>? tail = null;
    public required int Capacity { get; init; }

    private Dictionary<K, DoublyNode<V>> _lookup = new Dictionary<K, DoublyNode<V>>();
    private Dictionary<DoublyNode<V>, K> _reverseLookup = new Dictionary<DoublyNode<V>, K>();

    public void Update(K key, V value)
    {
        DoublyNode<V>? node;
        this._lookup.TryGetValue(key, out node);
        if (node == null)
        {
            node = new DoublyNode<V>(value);
            this._length++;
            Prepend(node);
            TrimCache();
            this._lookup.Add(key, node);
            this._reverseLookup.Add(node, key);
        }
        else
        {
            Detach(node);
            Prepend(node);
            node.Value = value;
        }
    }

    public V? Get(K key)
    {
        this._lookup.TryGetValue(key, out var node);
        if (node == null) return default;

        this.Detach(node);
        this.Prepend(node);

        return node.Value;
    }

    private void Detach(DoublyNode<V> node)
    {
        if (node.Prev != null)
        {
            node.Prev.Next = node.Next;
        }

        if (node.Next != null)
        {
            node.Next.Prev = node.Prev;
        }

        if (head == node) head = head.Next;
        if (tail == node) tail = tail.Prev;

        node.Next = null;
        node.Prev = null;
    }

    private void Prepend(DoublyNode<V> node)
    {
        if (head == null)
        {
            head = tail = node;
            return;
        }
        head.Prev = node;
        node.Next = head;
        head = node;
    }

    private void TrimCache()
    {
        if (_length <= Capacity) return ;

        var tail = this.tail!;
        this.tail = tail.Prev;
        this.Detach(tail);
        var val = this._reverseLookup[tail]!;
        this._lookup.Remove(val);
        this._reverseLookup.Remove(tail);
        this._length--;
    }
}
