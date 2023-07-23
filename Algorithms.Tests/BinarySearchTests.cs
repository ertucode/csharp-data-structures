namespace DataStructures.Tests;

public class BinarySearchTests
{
    [Fact]
    public void FindsOneVal()
    {
        var arr = new int[1] { 1 };
        Assert.Equal(0, BinarySearch.Search(arr, 1));
    }

    [Fact]
    public void DoesntFindIfDoesntExist()
    {
        var arr = new int[5] { 1, 2, 3, 4, 5 };
        Assert.Equal(-1, BinarySearch.Search(arr, 6));
    }

    [Fact]
    public void OddArrayLength()
    {
        var arr = new int[5] { 1, 2, 3, 4, 199 };
        Assert.Equal(0, BinarySearch.Search(arr, 1));
        Assert.Equal(1, BinarySearch.Search(arr, 2));
        Assert.Equal(2, BinarySearch.Search(arr, 3));
        Assert.Equal(3, BinarySearch.Search(arr, 4));
        Assert.Equal(4, BinarySearch.Search(arr, 199));
    }

    [Fact]
    public void EvenArrayLength()
    {
        var arr = new int[6] { 1, 2, 3, 4, 5, 100 };
        Assert.Equal(0, BinarySearch.Search(arr, 1));
        Assert.Equal(1, BinarySearch.Search(arr, 2));
        Assert.Equal(2, BinarySearch.Search(arr, 3));
        Assert.Equal(3, BinarySearch.Search(arr, 4));
        Assert.Equal(4, BinarySearch.Search(arr, 5));
        Assert.Equal(5, BinarySearch.Search(arr, 100));
    }
}
