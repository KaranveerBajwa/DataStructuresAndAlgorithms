using System;

namespace MinimumCoinsToMakeValue
{
  class Program
  {
    /*
     * Minimum coins to make to value
     * {25,10,5} value = 30 , output = 2
     * {9,6,5,1} value = 11 output = 11
     * */ 

    static void Main(string[] args)
    {
      Console.WriteLine(MinimumCoinsRecursive(new int[] { 25, 10, 5 }, 30));
      Console.WriteLine(MinimumCoinsRecursive(new int[] { 9,6,5,1}, 11));

      Console.WriteLine(MinimumCoinsTabulation(new int[] { 3,2,1,4 }, 5));
      Console.WriteLine(MinimumCoinsTabulation(new int[] { 25, 10, 5 }, 30));
      Console.WriteLine(MinimumCoinsTabulation(new int[] { 9, 6, 5, 1 }, 11)); ;
      Console.WriteLine("What a wonderful World!");
    }

    static int MinimumCoinsRecursive(int[] coins, int target)
    {
      if (target == 0)
        return 0;


      int res = Int32.MaxValue;
      for (int i = 0; i < coins.Length; i++)
      {
        if (target - coins[i] >= 0)
        {
          int subRes = MinimumCoinsRecursive(coins, target - coins[i]);
          if (subRes != Int32.MaxValue)
            res = Math.Min(res, subRes+1);
        }
      }
      return res;
    }

    static int MinimumCoinsTabulation(int[] coins, int target)
    {
      int[] dp = new int[target + 1];
      dp[0] = 0;
      for (int i = 1; i <= target; i++)
      {
        dp[i] = Int32.MaxValue;
      }

      for (int i = 1; i <= target; i++)
      {
        for (int j = 0; j < coins.Length; j++)
        {
          if (i - coins[j] >= 0)
            dp[i] = Math.Min(dp[i], dp[i -coins[j]]);          
        }
        if (dp[i] != Int32.MaxValue)
          dp[i]++;
      }
      return dp[target];
    }
  
  }
}
