namespace DataStructures;

public class PNode<V>
{
    public V Value { get; set; }
    public PNode<V>? Prev { get; set; }

    public PNode(V value)
    {
        Value = value;
    }
}
