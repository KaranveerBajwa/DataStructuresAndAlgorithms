using System;

namespace LongestIncreasingSubsequence
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 3, 4, 2, 8, 10 };
      Console.WriteLine(CountLongestIncreasingSubsequence(nums));

      int[] nums1 = { 3, 4, 5, 8, 10,5,1 };
      Console.WriteLine(CountLongestIncreasingSubsequence(nums1));

      int[] nums2 = { 10, 5, 18, 7, 2, 9 };
      Console.WriteLine(CountLongestIncreasingSubsequence(nums2));
      Console.WriteLine("What a wonderful World!");
    }

    static int CountLongestIncreasingSubsequence(int[] nums)
    {
      if (nums == null)
        throw new ArgumentNullException("Please provide valid input");

      int[] dp = new int[nums.Length];
      dp[0] = 1;

      for (int i = 1; i < nums.Length; i++)
      {
        dp[i] = 1;  
        for (int j = 0; j < i; j++)
        {
          if (nums[i] > nums[j]) // if there a re equal elements do we include that
          {
            dp[i] = Math.Max(dp[i], dp[j] + 1);
          }
        }
      }
      int max = 0;
      for (int i=0; i < nums.Length; i++)
      {
        if (max < dp[i])
          max = dp[i];
      }
      return max;
    }
  }
}
