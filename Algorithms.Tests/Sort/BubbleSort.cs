using Algorithms.Sort;

namespace Algorithms.Tests;

public class BubbleSortTests
{
    [Fact]
    public void Works()
    {
        var arr = new int[10] { 9, 3, 4, 41, 51, 52, 92, 10, 1000, 0 };
        BubbleSort.Sort(arr);
        Assert.Equal(0, arr[0]);
        Assert.Equal(3, arr[1]);
        Assert.Equal(4, arr[2]);
        Assert.Equal(1000, arr[9]);
    }
}
