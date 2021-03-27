using System;

namespace DutchNationalFlag
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr0 = null;
      int[] ar00 = { };

      int[] arr = { 0, 0, 0, 0 };
      DNF(arr, 1);
      Console.WriteLine(String.Join(",", arr));

      int[] arr1 = { 2, 3, 1, 0, 1, 1, 3 };
      DNF(arr1, 1);
      Console.WriteLine(String.Join(",", arr1));

      int[] arr2 = { 2, 2, 2, 0 };
      DNF(arr2, 1);
      Console.WriteLine(String.Join(",", arr2));

      Console.WriteLine("Hello World!");
    }

    static void DNF(int[] arr, int midNum)
    {
      if (arr == null || arr.Length == 0)
        return;

      int start = 0;
      int mid = 0;
      int end = arr.Length - 1;
      while (mid <= end)
      {
        if (arr[mid] < midNum)
        {
          Swap(arr, mid, start);
          start++;
          mid++;
        }

        else if (arr[mid] > midNum)
        {
          Swap(arr, mid, end);
          end--;
        }
        else
          mid++;        
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
