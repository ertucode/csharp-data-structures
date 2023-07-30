using Algorithms.Sort;

namespace Algorithms.Tests;

public class QuickSortTests
{
    [Fact]
    public void Works()
    {
        var arr = new int[10] { 9, 3, 4, 41, 51, 52, 92, 10, 1000, 0 };
        QuickSort.Sort(arr);
        Assert.Equal(0, arr[0]);
        Assert.Equal(3, arr[1]);
        Assert.Equal(4, arr[2]);
        Assert.Equal(1000, arr[9]);
    }

    [Fact]
    public void LengthOf1()
    {
        var arr = new int[1] { 9 };
        QuickSort.Sort(arr);
        Assert.Equal(9, arr[0]);
    }

    [Fact]
    public void LengthOf2()
    {
        var arr = new int[2] { 10, 9 };
        QuickSort.Sort(arr);
        Assert.Equal(9, arr[0]);
        Assert.Equal(10, arr[1]);
    }

    [Fact]
    public void LengthOf3()
    {
        var arr = new int[3] { 10, 9, 11 };
        QuickSort.Sort(arr);
        Assert.Equal(9, arr[0]);
        Assert.Equal(10, arr[1]);
        Assert.Equal(11, arr[2]);
    }
}
