namespace DataStructure.Tests;

public class DoubleNodeTests
{
    [Fact]
    public void NextSetsNext()
    {
        var node = new DoublyNode<int>(2);
        var next = new DoublyNode<int>(4);
        node.Next = next;
        Assert.Same(node.Next , next);
    }
}
