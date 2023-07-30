namespace DataStructures.Tests;

public class QueueTests
{
    [Fact]
    public void Works()
    {
        var queue = new Queue<int>();

        queue.Enqueue(3);
        queue.Enqueue(5);
        queue.Enqueue(4);

        Assert.Equal(3, queue.Peek());
        Assert.Equal(3, queue.Dequeue());
        Assert.Equal(5, queue.Dequeue());

        queue.Enqueue(11);
        Assert.Equal((uint)2, queue.Length);

        Assert.Equal(4, queue.Dequeue());
        Assert.Equal(11, queue.Dequeue());
        Assert.Equal((uint)0, queue.Length);
        Assert.Equal(default, queue.Dequeue());
    }
}
