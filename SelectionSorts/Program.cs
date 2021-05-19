using System;

namespace SelectionSorts
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 10};
      SelectionSort(arr);
      Console.WriteLine("What a wonderful World!");
    }

    static void SelectionSort(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        int min = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
          if (arr[j] < arr[min])
            min = j;
        }
        Swap(arr, i, min);
      }
    }

    static void Swap(int[] arr, int i, int j)
    {
      int temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }
  }
}
