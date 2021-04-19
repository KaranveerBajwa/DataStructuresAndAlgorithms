using System;

namespace LongestCommonSubsequence
{
  class Program
  {
    // always ask if the comparision is case sensitive

    static void Main(string[] args)
    {

      Console.WriteLine(LCSRecursive("ABCD", "ABCD"));
      Console.WriteLine(LCSRecursive("ABCD", "EFGH"));
      Console.WriteLine(LCSRecursive("A", "ABCD"));


      Console.WriteLine(LCSRecursiveMemo("ABCD", "ABCD"));
      Console.WriteLine(LCSRecursiveMemo("ABCD", "EFGH"));
      Console.WriteLine(LCSRecursiveMemo("A", "ABCD"));


      Console.WriteLine(LCSTabulation("ABCD", "ABCD"));
      Console.WriteLine(LCSTabulation("ABCD", "EFGH"));
      Console.WriteLine(LCSTabulation("A", "ABCD"));

      Console.WriteLine("What a wonderful World!");
    }

    static int LCSRecursive(string s1, string s2)
    {
      return LCSRecursiveHelper(s1, s2, s1.Length -1, s2.Length -1);    
    }

    static int LCSRecursiveMemo(string s1, string s2)
    {
      int[,] memo = new int[s1.Length  , s2.Length  ];
      for (int i = 0; i < memo.GetLength(0); i++)
        for (int j = 0; j < memo.GetLength(1); j++)
          memo[i, j] = -1;

      return LCSRecursiveMemoHelper(s1, s2, memo.GetLength(0) -1, memo.GetLength(1) -1, memo);
      
    }

    static int LCSTabulation(string s1, string s2)
    {
      // create a matrix as there will change in two dimensions of size m+1, and n+1
      // 1st row will be zero as when you compare the empty string to string there are no match
      // 1st column will be zero as when you compare string to empty string there is not match

      int[,] dp = new int[s1.Length + 1, s2.Length + 1];

      for (int i = 1; i <= s1.Length; i++)
        for (int j = 1; j <= s2.Length; j++)
        {
          if (s1[i - 1] == s2[j - 1])
            dp[i, j] = 1 + dp[i - 1, j - 1];
          else
            dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);        
        }
      return dp[s1.Length, s2.Length];
    }


    static int LCSRecursiveHelper(string s1, string s2, int m, int n) // m and are eqaul to length of the string
    {
      if (m < 0 || n < 0)
        return 0;

      if (s1[m ] == s2[n])
        return 1 + LCSRecursiveHelper(s1, s2, m - 1, n - 1);
      else
        return Math.Max(LCSRecursiveHelper(s1, s2, m - 1, n), LCSRecursiveHelper(s1, s2, m, n - 1));
    }


    static int LCSRecursiveMemoHelper(string s1, string s2, int m, int n, int[,] memo) // m and are eqaul to length of the string
    {
      if (m < 0 || n < 0)
        return 0;
      if (memo[m , n ] != -1)
        return memo[m , n ];

      if (s1[m] == s2[n])
        memo[m, n] =  1 + LCSRecursiveMemoHelper(s1, s2, m - 1, n - 1, memo);
      else
        memo[m, n] = Math.Max(LCSRecursiveMemoHelper(s1, s2, m - 1, n, memo), LCSRecursiveMemoHelper(s1, s2, m, n - 1, memo));

      return memo[m, n];
    }
  }
}
