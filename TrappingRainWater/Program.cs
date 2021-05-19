using System;

namespace TrappingRainWater
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(TrappedRainWater(new int[] { 5,0,6,2,3}));
      Console.WriteLine("What a wonderful World!");
    }

    static int TrappedRainWater(int[] arr)
    {
      int n = arr.Length;
      int[] leftMax = new int[n];
      int[] rightMax = new int[n];

      leftMax[0] = arr[0];
      for (int i = 1; i < n; i++)
      {
        leftMax[i] = Math.Max(arr[i], leftMax[i - 1]);
      }

      rightMax[n - 1] = arr[n - 1];
      for (int i = n - 2; i >= 0; i--)
      {
        rightMax[i] = Math.Max(arr[i], rightMax[i + 1]);
      }

      int res = 0;
      for (int i = 1; i < n - 1; i++)
      {
        res = res + Math.Min(leftMax[i], rightMax[i]) - arr[i];
      }
      return res;
    }
  }
}
