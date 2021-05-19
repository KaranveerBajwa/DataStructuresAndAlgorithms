using System;

namespace InsertionSort
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 20,5,10,60,40,30};
      InsertionSorting(arr);
      Console.WriteLine("What a wonderful World!");
    }

    static void InsertionSorting(int[] arr)
    {
      for (int i = 0; i < arr.Length; i++)
      {
        int j = i;
        int value = arr[i];
        while (j > 0 && arr[j - 1] > value)
        {
          arr[j] = arr[j - 1];
          j--;
        }
        arr[j] = value;
      }

    }
  }
}
