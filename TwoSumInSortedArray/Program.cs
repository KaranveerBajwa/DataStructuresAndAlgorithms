using System;

namespace TwoSumInSortedArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 1, 2, 2, 4, 5, 6 };
      Pair result = TwoSum(arr, 9);
      Console.WriteLine($"{result.Start}, {result.End}");
    }

    static Pair TwoSum(int[] arr, int target)
    {
      if (arr == null || arr.Length == 0)
        return null;
      int start = 0;
      int end = arr.Length - 1;
      while (start < end) // if we can return the single index start <= end
      {
        int sum = arr[start] + arr[end];
        if (sum < target)
          start++;
        else if (sum > target)
          end--;
        else
          return new Pair(start, end);
      }
      return null;
    }

  }
  public class Pair { 
    public int Start { get; set; }
    public int End { get; set; }
    public Pair(int x, int y)
    {
      Start = x;
      End = y;
    }
  }
}
