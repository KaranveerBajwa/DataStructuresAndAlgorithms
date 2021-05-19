using System;
using System.Timers;

namespace MoveAllZeroesToRight
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = null;
      MoveZeroesToRight(arr);
      int[] arr1 = { 1 };
      MoveZeroesToRight(arr1);
      Console.WriteLine(String.Join(",", arr1));
      int[] arr2 = { 0, 0, 0 };
      MoveZeroesToRight(arr2);
      Console.WriteLine(String.Join(",", arr2));
      int[] arr3 = { 1, 2, 0, 4, 5, 0 };
      MoveZeroesToRight(arr3);
      Console.WriteLine(String.Join(",", arr3));
      int[] arr4 = { 1, 0, 3, 2, 0, 4, 5, 0 };
      MoveZeroesToRight(arr4);
      Console.WriteLine(String.Join(",", arr4 ));
      int[] ip = { 0, 0 };
      MoveToZeroesToRightMaintainOrder(ip);
      Console.WriteLine();

    }

    // check for null or empty array 
    // set start = 0, end = arr.Length-1
    // if item at index start equal to 0 swap with item at end position and decrement  end
    // else increment start
    // Process till start is less than end 

    static void MoveZeroesToRight(int[] arr)
    {
      if (arr == null || arr.Length == 0)
        return;

      int start = 0;
      int end = arr.Length - 1;
      while (start < end)
      {
        if (arr[start] == 0)
        {
          Swap(arr, start, end--);
        }
        else
          start++;
      }
    }

    static void MoveToZeroesToRightMaintainOrder(int[] arr)
    {
      int left = -1;
      int right = 0;
      while (right < arr.Length)
      {
        if (arr[right] != 0)
        {
          left = left + 1;
          Swap(arr, left, right);
          right++;
        }
        else
          right++;
      
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
