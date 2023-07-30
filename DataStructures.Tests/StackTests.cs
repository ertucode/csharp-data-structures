namespace DataStructures.Tests;

public class StackTests
{
    [Fact]
    public void Works()
    {
        var stack = new Stack<int>();

        stack.Push(3);
        stack.Push(5);
        stack.Push(4);

        Assert.Equal(4, stack.Peek());
        Assert.Equal(4, stack.Pop());
        Assert.Equal(5, stack.Pop());

        stack.Push(11);
        Assert.Equal((uint)2, stack.Length);

        Assert.Equal(11, stack.Pop());
        Assert.Equal(3, stack.Pop());
        Assert.Equal((uint)0, stack.Length);
        Assert.Equal(default, stack.Pop());
    }
}
