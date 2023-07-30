namespace DataStructures;

public class NNode<V>
{
    public V Value { get; set; }
    public NNode<V>? Next { get; set; }

    public NNode(V value)
    {
        Value = value;
    }
}
