using System;
using System.Threading;

namespace MoveAllZeroesToLeft
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = null;
      MoveZeroesToLeft(arr);
      int[] arr1 = { 1 };
      MoveZeroesToLeft(arr1);
      Console.WriteLine(String.Join(",", arr1));
      int[] arr2 = { 0, 0, 0 };
      MoveZeroesToLeft(arr2);
      Console.WriteLine(String.Join(",", arr2));
      int[] arr3 = { 1, 2, 0, 4, 5, 0 };
      MoveZeroesToLeft(arr3);
      Console.WriteLine(String.Join(",", arr3));
      int[] arr4 = { 1, 0, 3, 2, 0, 4, 5, 0 };
      MoveZeroesToLeft(arr4);
      Console.WriteLine(String.Join(",", arr4));
      Console.WriteLine("Hello World!");
    }

    static void MoveZeroesToLeft(int[] arr)
    {
      if (arr == null || arr.Length == 0)
        return;

      int start = 0;
      int end = arr.Length - 1;
      while (start < end)
      {
        if (arr[end] == 0)
        {
          Swap(arr, start, end);
          start++;
        }
        else
          end--;        
      }    
    }

    static void Swap(int[] arr, int start, int end)
    {
      int temp = arr[start];
      arr[start] = arr[end];
      arr[end] = temp;
    }
  }
}
