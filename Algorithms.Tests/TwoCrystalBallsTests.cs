namespace Algorithms.Tests;

public class TwoCrystalBallsTests
{
    private bool[] CreateBreaksArr(uint idx, uint length)
    {
        bool[] arr = new bool[length];

        for (uint i = 0; i < length; i++)
        {
            arr[i] = !(i < idx);
        }
        return arr;
    }

    [Fact]
    public void Works()
    {
        var arr = CreateBreaksArr(10, 30);
        Assert.Equal(10, TwoCrystalBalls.Solve(arr));
    }

    [Fact]
    public void OnLastElement()
    {
        var arr = CreateBreaksArr(57, 58);
        Assert.Equal(57, TwoCrystalBalls.Solve(arr));
    }

    [Fact]
    public void WithSmallArr()
    {
        var arr = CreateBreaksArr(1, 2);
        Assert.Equal(1, TwoCrystalBalls.Solve(arr));
    }
}
