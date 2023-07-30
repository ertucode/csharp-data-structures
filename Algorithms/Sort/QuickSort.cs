namespace Algorithms.Sort;

public static class QuickSort
{
    public static void Sort(int[] arr)
    {
        SortHelper(arr, 0, arr.Length - 1);
    }

    private static void SortHelper(int[] arr, int lo, int hi)
    {
        if (lo >= hi)
            return;
        int p = Partition(arr, lo, hi);

        SortHelper(arr, lo, p - 1);
        SortHelper(arr, p + 1, hi);
    }

    private static int Partition(int[] arr, int lo, int hi)
    {
        int pivot = hi;
        int swap = lo;

        for (int i = lo; i < hi; i++)
        {
            if (arr[i] < arr[pivot])
            {
                Swap(arr, i, swap);
                swap++;
            }
        }
        Swap(arr, swap, pivot);
        return swap;
    }

    private static void Swap(int[] arr, int i1, int i2)
    {
        int temp = arr[i1];
        arr[i1] = arr[i2];
        arr[i2] = temp;
    }
}
