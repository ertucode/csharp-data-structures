namespace DataStructure;

public class DoublyNode<V>
{
    public V Value { get; set; }
    public DoublyNode<V>? Next { get; set; }
    public DoublyNode<V>? Prev { get; set; }

    public DoublyNode(V value)
    {
        Value = value;
    }
}
