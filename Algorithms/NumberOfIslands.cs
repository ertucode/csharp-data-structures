namespace Algorithms;

public class NumberOfIslands
{
    public int[,] Grid { init; get; }
    private int _firstLength;
    private int _secondLength;
    private bool[,] _visited;

    public NumberOfIslands(int[,] grid)
    {
        Grid = grid;
        _firstLength = grid.GetLength(0);
        _secondLength = grid.GetLength(1);
        _visited = new bool[_firstLength, _secondLength];
    }

    public uint Solve()
    {
        uint num = 0;

        for (int i = 0; i < _firstLength; i++)
        {
            for (int j = 0; j < _secondLength; j++)
            {
                if (_visited[i, j])
                    continue;

                _visited[i, j] = true;

                if (Grid[i, j] == 1)
                {
                    num++;
                    VisitNeighbors(i, j);
                }
            }
        }

        return num;
    }

    private void VisitNeighbor(int i, int j)
    {
        if (i == _firstLength || j == _secondLength || i == -1 || j == -1)
            return;
        if (_visited[i, j])
            return;

        _visited[i, j] = true;
        if (Grid[i, j] == 1)
        {
            VisitNeighbors(i, j);
        }
    }

    private void VisitNeighbors(int i, int j)
    {
        VisitNeighbor(i + 1, j);
        VisitNeighbor(i - 1, j);
        VisitNeighbor(i, j + 1);
        VisitNeighbor(i, j - 1);
    }
}
