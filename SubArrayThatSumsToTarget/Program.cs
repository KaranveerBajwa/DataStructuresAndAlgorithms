using System;

namespace SubArrayThatSumsToTarget
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 1, 2, 5, 3, 1, 5, 1 };
      Pair res = GetIndicesRangeWithTargetSum(arr, 4);
      Console.WriteLine("Hello World!"); 
    }

    static Pair GetIndicesRangeWithTargetSum(int[] arr, int target)
    {
      int sum = 0;
      int start = 0;
      int end = 0;

      while (start < arr.Length)
      {
        if (start > end)
          end = start;

        if (sum > target) // Shrink
        {
          sum = sum - arr[start];
          start++;
        }
        else if (sum < target)
        {
          sum = sum + arr[end];
          end++;
        }
        else
          return new Pair(start, end);
      }
      throw new Exception("Target sum not found");
    }

  }

  public class Pair { 
   public int Start { get; set; }
   public int End { get; set; }
    public Pair(int start, int end)
    {
      Start = start;
      End = end;
    }

  }
}
