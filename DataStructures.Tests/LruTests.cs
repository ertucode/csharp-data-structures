namespace DataStructures.Tests;

public class LruTests
{
    [Fact]
    public void UpdateAddsItem()
    {
        var lru = new Lru<char, int>() { Capacity = 4 };
        lru.Update('2', 2);
        var val = lru.Get('2');

        Assert.Equal(2, val);
    }

    [Fact]
    public void ItemIsRemovedWhenCapacityIsReached()
    {
        var lru = new Lru<char, int>() { Capacity = 2 };
        lru.Update('2', 2);
        lru.Update('3', 3);
        lru.Update('4', 4);
        var val = lru.Get('2');

        Assert.Equal(default, val);
    }

    [Fact]
    public void UpdatingTheItemIncreasesPriority()
    {
        var lru = new Lru<char, int>() { Capacity = 2 };
        lru.Update('2', 2);
        lru.Update('3', 3);
        lru.Update('2', 2);
        lru.Update('4', 4);

        Assert.Equal(default, lru.Get('3'));
        Assert.Equal(2, lru.Get('2'));
    }

    [Fact]
    public void UpdatingTheItemChangesItsValue()
    {
        var lru = new Lru<char, int>() { Capacity = 2 };
        lru.Update('2', 2);
        lru.Update('2', 20);

        Assert.Equal(20, lru.Get('2'));
    }
}
