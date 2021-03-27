using System;

namespace SortSortedArrayAfterSquared
{
  class Program
  {
    // {-4,-3,0,1,2}
    //{0,1,4,9,16}
    static void Main(string[] args)
    {
      int[] arr= { -4, -3, 0, 1, 2 };
      int[] res = SortedSquaredArray(arr);
      Console.WriteLine(String.Join(",", res));
      Console.WriteLine("Hello World!");
    }

    static int[] SortedSquaredArray(int[] arr)
    {
      int start = 0;
      int end = arr.Length - 1;
      int[] res = new int[arr.Length];
      int insertIndex = arr.Length -1;
      while (insertIndex >=0)
      {
        if (Math.Abs(arr[start]) > Math.Abs(arr[end]))
        {
          res[insertIndex] = arr[start] * arr[start];
          start++;
        }
        else
        {
          res[insertIndex] = arr[end] * arr[end];
          end--;
        }
        insertIndex--;
      }
      return res;
      }
  }
}
