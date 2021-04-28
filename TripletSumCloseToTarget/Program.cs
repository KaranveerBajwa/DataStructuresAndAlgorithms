using System;
using System.Collections.Generic;
namespace TripletSumCloseToTarget
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(SumClosestToTarget(new int[] {-2,0,1,2 }, 2));
      Console.WriteLine(SumClosestToTarget(new int[] {-3,-1,1,2}, 1));
      Console.WriteLine(SumClosestToTarget(new int[] {1,0,1,1 }, 100));

      Console.WriteLine("What a wonderful World!");
    }

    static int SumClosestToTarget(int[] arr, int target)
    {      
      Array.Sort(arr);
      int smallestDiff = Int32.MaxValue;
      int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        int left = i + 1;
        int right = arr.Length - 1;
        while (left < right)
        {
          sum = arr[i] + arr[left] + arr[right];
          int diff = Math.Abs(target - sum);
          if (diff < smallestDiff)
            smallestDiff = diff;
          if (sum > target)
          {
            right--;
          }
          else if (sum < target)
          {
            left++;
          }
          else
            return sum;
        }
      }
      return target - smallestDiff; ;    
    }
  }
}
