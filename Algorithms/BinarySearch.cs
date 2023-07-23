namespace Algorithms;

public static class BinarySearch
{
    private static int SearchHelper<T>(T[] arr, T val, int lo, int hi)
        where T : IComparable
    {
        while (lo <= hi)
        {
            int mi = lo + (hi - lo) / 2;
            T curr = arr[mi]!;

            if (curr.Equals(val))
                return mi;
            else if (curr.CompareTo(val) <= 0)
            {
                lo = mi + 1;
            }
            else
            {
                hi = mi;
            }
        }

        return -1;
    }

    public static int Search<T>(T[] arr, T val)
        where T : IComparable
    {
        return SearchHelper(arr, val, 0, arr.Length - 1);
    }
}
