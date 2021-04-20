using System;

namespace MinimumJumpsToReachEnd
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 3, 4, 2, 1, 2, 1 };
      int[] arr1  = { 4,1,5,3,1,3,2,1,8};
      Console.WriteLine(MinimumJumps(arr));
      Console.WriteLine(MinimumJumps(arr1));

      Console.WriteLine(MinimumJumpsTabulation(arr));
      Console.WriteLine(MinimumJumpsTabulation(arr1));

      Console.WriteLine("What a wonderful World!");
    }

    // loop through array from start to next to the last element
    // and for all the array elements from which we can reach the last element 
    // i.e there value Plus the ith index if >= last element index
    // recurisively caluclate the minimum steps

    static int MinimumJumps(int[] arr)
    {
      return MinimumJumpsHelper(arr, arr.Length-1);
    }

    static int MinimumJumpsTabulation(int[] nums)
    {
      int[] dp = new int[nums.Length];
      dp[0] = 0;
      int lastIndex = nums.Length - 1;
      for (int i = 1; i < nums.Length; i++)
        dp[i] = Int32.MaxValue;

      for (int i = 1; i < nums.Length; i++)
        for (int j = 0; j < i; j++)
        { 
          if(nums[j] + j >= i)
          {
            if (dp[j] != Int32.MaxValue)
            {
              dp[i] = Math.Min(dp[i], dp[j] + 1);
            }
          }
        }
      return dp[lastIndex];
    }

    static int MinimumJumpsHelper(int[] arr, int n)
    {
      if (n == 0)
        return 0;

      int res = Int32.MaxValue;

      for (int i = 0; i <= n - 1; i++)
      {
        if (arr[i] + i >= n)
        {
          int subRes = MinimumJumpsHelper(arr, i); // number of ways you can get to this index
          if (subRes != Int32.MaxValue)
            res = Math.Min(res, subRes + 1);
        }      
      }
      return res;
    }

  }
}
