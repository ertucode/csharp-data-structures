namespace Algorithms;

public static class TwoCrystalBalls
{
    public static int Solve(bool[] breaks)
    {
        int jumpAmount = (int)(Math.Floor(Math.Sqrt(breaks.Length)));

        var i = jumpAmount;

        for (; i < breaks.Length; i = i + jumpAmount)
        {
            if (breaks[i])
            {
                break;
            }
        }

        var prevStart = i - jumpAmount;
        var last = Math.Min(i + 1, breaks.Length);
        for (int j = prevStart; j < last; j++)
        {
            if (breaks[j])
                return j;
        }
        return -1;
    }
}
