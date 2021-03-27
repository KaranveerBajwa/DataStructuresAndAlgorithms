using System;
using System.Dynamic;
using System.Globalization;

namespace MaximumSubArraySum
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { -2, -2, 3, 4, -2, 1 };
      Console.WriteLine($"MaxSum of Subarray : {GetTwoSumON2(arr)}");
      Console.WriteLine($"Maxsum: {String.Join("," , GetMaxSum(arr))}");
      int[] res = GetMaxSumSubArray(arr);
      Console.WriteLine("Hello World!");
    }

    static int[] GetMaxSum(int[] arr)
    {
      int[] subArrayIndicies = new int[2];
      if (arr == null || arr.Length == 0)
        throw new ArgumentException("Array cannot be null or empty");
      int curSum = arr[0];
      int maxSum = arr[0];
      int start = 0;
      int end = 0;
      for (int i = 1; i < arr.Length; i++)
      {
        //curSum = Math.Max(arr[i], curSum + arr[i]);
        //maxSum = Math.Max(curSum, maxSum);
        int sum = curSum + arr[i];
        if (arr[i] > sum)
        {
          curSum = arr[i];
          start = i;
          end = i;
        }
        else {
          curSum = sum;
        }

        if (curSum > maxSum)
        {
          end = i;
          maxSum = curSum;
        }
      }
      subArrayIndicies[0] = start;
      subArrayIndicies[1] = end;
      return subArrayIndicies;
    }

    static int GetTwoSumON2(int[] arr)
    {
      if (arr == null || arr.Length == 0)
        return 0;
      int maxSum = arr[0];
      for (int i = 0; i < arr.Length; i++)
      {
        int sum = 0;
        for (int j = i; j < arr.Length; j++)
        {
          sum += arr[j];
          if (sum > maxSum)
          {
            maxSum = sum;

          }
        }
      }
      return maxSum;    
    }

    static int[] GetMaxSumSubArray(int[] arr)
    {
      int[] subArrayIndicies = new int[2];
      if (arr == null || arr.Length == 0)
        return subArrayIndicies;
      int maxSum = arr[0];
      int subArraySize = Int32.MaxValue; ;
      for (int i = 0; i < arr.Length; i++)
      {
        int sum = 0;
        for (int j = i; j < arr.Length; j++)
        {
          sum += arr[j];
          if (sum >= maxSum)
          {
            maxSum = sum;
            if (subArraySize > j - i) // to get subarrray with minimum size
            {
              subArrayIndicies[0] = i;
              subArrayIndicies[1] = j;
            }
          }
        }
      }
      return subArrayIndicies;
    }


  }
}
