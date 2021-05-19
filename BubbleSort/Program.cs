using System;

namespace BubbleSort
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 10,2 };
      BubbleSort(arr);
      Console.WriteLine("What a wonderful World!");
    }
    // loop through all elements
    // from start
    // compare to the next element and move the maximum to the end

    static void BubbleSort(int[] arr)
    {
      int n = arr.Length;
      for (int i = 0; i < n; i++)
      {
        for (int j = 1; j < n - i; j++)
        {
          if (arr[j] < arr[j-1])
            Swap(arr, j-1, j);
        }

      }
    }

    private static void Swap(int[] arr, int v, int j)
    {
      int temp = arr[v];
      arr[v] = arr[j];
      arr[j] = temp;

    }
  }
}
