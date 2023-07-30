namespace Algorithms.Tests;

public class NumberOfIslandsTests
{
    [Fact]
    public void Works()
    {
        int[,] grid = new[,]
        {
            { 1, 1, 0, 1 },
            { 1, 0, 0, 1 },
            { 0, 1, 1, 1 }
        };
        var solver = new NumberOfIslands(grid);
        Assert.Equal((uint)2, solver.Solve());
    }

    [Fact]
    public void NoIsland()
    {
        int[,] grid = new[,]
        {
            { 0, },
        };
        var solver = new NumberOfIslands(grid);
        Assert.Equal((uint)0, solver.Solve());
    }

    [Fact]
    public void OneIsland()
    {
        int[,] grid = new[,]
        {
            { 1, },
        };
        var solver = new NumberOfIslands(grid);
        Assert.Equal((uint)1, solver.Solve());
    }

    [Fact]
    public void OneIslandWeird()
    {
        int[,] grid = new[,]
        {
            { 1, 1, 1, 1 },
            { 1, 0, 0, 1 },
            { 1, 1, 1, 1 }
        };
        var solver = new NumberOfIslands(grid);
        Assert.Equal((uint)1, solver.Solve());
    }

    [Fact]
    public void NoNeighbor()
    {
        int[,] grid = new[,]
        {
            { 1, 0, 1, 0 },
            { 0, 1, 0, 1 },
            { 1, 0, 1, 0 }
        };
        var solver = new NumberOfIslands(grid);
        Assert.Equal((uint)6, solver.Solve());
    }
}
