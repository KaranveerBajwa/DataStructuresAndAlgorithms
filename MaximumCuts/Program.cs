using System;

namespace MaximumCuts
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(MaximumCut(5, 1, 2, 3));
      Console.WriteLine(MaximumCut(23, 12, 11, 13));
      Console.WriteLine(MaximumCut(3, 2, 4, 2));

      Console.WriteLine("What a wonderful World!");
    }

    static int MaximumCut(int n, int a, int b, int c)
    {
      int[] dp = new int[n+1];
      dp[0] = 0;

      for (int i = 1; i <= n; i++)
      {
        dp[i] = -1;
        if (i - a >= 0)
          dp[i] = Math.Max(dp[i], dp[i - a]);
        if (i - b >= 0)
          dp[i] = Math.Max(dp[i], dp[i - b]);
        if (i - c >= 0)
          dp[i] = Math.Max(dp[i], dp[i - c]);

        if (dp[i] != -1)
          dp[i]++;
      }
      return dp[n];    
    }
  }
}
