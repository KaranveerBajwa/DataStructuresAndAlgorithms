using System;
using System.Text;

namespace LongestCommonSubsequence
{
  class Program
  {
    // always ask if the comparision is case sensitive

    static void Main(string[] args)
    {

      //Console.WriteLine(LCSRecursive("ABCD", "ABCD"));
      //Console.WriteLine(LCSRecursive("ABCD", "EFGH"));
      //Console.WriteLine(LCSRecursive("A", "ABCD"));


      //Console.WriteLine(LCSRecursiveMemo("ABCD", "ABCD"));
      //Console.WriteLine(LCSRecursiveMemo("ABCD", "EFGH"));
      //Console.WriteLine(LCSRecursiveMemo("A", "ABCD"));


      //Console.WriteLine(LCSTabulation("ABCD", "ABCD"));
      //Console.WriteLine(LCSTabulation("ABCD", "EFGH"));
      //Console.WriteLine(LCSTabulation("A", "ABCD"));
      Console.WriteLine(LCSTabulation("ABCDEFG", "ABDFFGH"));

      Console.WriteLine(LCSTabulation("AGGTAB", "GXTXAYB"));

      
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

      //for (int i = 0; i < dp.GetLength(0); i++)
      //{
      //  Console.WriteLine();
      //  Console.Write("  ");
      //  for (int j = 0; j < dp.GetLength(1); j++)
      //    Console.Write(dp[i, j] + " ");
      //}

      int m = 0; int n = 0;
      StringBuilder sb = new StringBuilder();
      int count = 0;
      while (m < s1.Length && n < s2.Length )
      {
        if (s1[m] == s2[n])
        {
          sb.Append(s1[m]);
          m++;
          n++;
        }
        else if (dp[m + 1, n] <= dp[m, n + 1])
        {
          sb.Append($"-{s1[m]}");
          m++;
        }
        else
        {
          sb.Append($"+{s2[n - 1]}");
          n++;
        }
      }

      //while (n <= s2.Length)
      //{
      //  sb.Append($"+{s2[n-1]}");
      //  n = n + 1;
      //}
      PrintLCS(dp, s1, s2);
      //Console.WriteLine(sb.ToString());


      return dp[s1.Length, s2.Length];
    }


    static string DiffString(string s1, string s2)
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

      int m = 0; int n = 0;
      StringBuilder sb = new StringBuilder();

      while (m < s1.Length && n < s2.Length)
      {
        if (s1[m] == s2[n])
        {
          sb.Append(s1[m]);
          m++;
          n++;
        }
        else if (dp[m +1 , n] <= dp[m, n + 1])
        {
          sb.Append($"-{s1[m]}");
          m++;
        }
        else
        {
          sb.Append($"+{s2[n]}");
          n++;
        }
      }

      while (n < s2.Length)
      {
        sb.Append($"+{s2[n]}");
        n = n + 1;
      }

      return sb.ToString();


    }

    static void diffBetweenTwoStrings(string source, string target)
    {
      int[,] dp = new int[source.Length + 1, target.Length + 1];

      //for i from 0 to source.length:

      //    dp[i][target.length] = 0
      //for j from 0 to target.length:
      //  dp[source.length][j] = target.length - j


      for (int i = source.Length - 1; i >= 0; i--)
        for (int j = target.Length - 1; j >= 0; j--)
        {
          if (source[i] == target[j])
          {
            dp[i, j] = dp[i + 1, j + 1];
          }
          else

            dp[i, j] = 1 + Math.Min(dp[i + 1, j], dp[i, j + 1]);
        }
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

    static void PrintLCS(int[,] L, string X, string Y)
    {
      int m = L.GetLength(0) -1 ;
      int n = L.GetLength(1) -1 ;
      // Following code is used to print LCS
      int index = L[m, n];
      int temp = index;

      // Create a character array 
      // to store the lcs string
      char[] lcs = new char[index + 1];
      string s = "";
      // Set the terminating character
      lcs[index] = '\0';

      // Start from the right-most-bottom-most corner
      // and one by one store characters in lcs[]
      int k = m, l = n;
      while (k > 0 && l > 0)
      {
        // If current character in X[] and Y 
        // are same, then current character 
        // is part of LCS
        if (X[k - 1] == Y[l - 1])
        {
          // Put current character in result
          lcs[index - 1] = X[k - 1];
          s = X[k - 1] + s;
          // reduce values of i, j and index
          k--;
          l--;
          index--;
        }

        // If not same, then find the larger of two and
        // go in the direction of larger value
        else if (L[k - 1, l] > L[k, l - 1])
        {
          s = "-" + X[k - 1] + s;
          k--;
        }
        else
        {
          s = "+" + Y[l - 1] + s;
          l--;
        }
      }

      while (l > 0)
      {
          s = "+" + Y[l - 1] + s;
          l--;
      }

      while (k > 0)
      {
        s = "-" + X[k - 1] + s;
        k--;
      }
      // Print the lcs
      Console.Write("LCS of " + X + " and " + Y + " is ");
      for (int q = 0; q <= temp; q++)
        Console.Write(lcs[q]);
      Console.WriteLine();
      Console.WriteLine(s);
    
    }

     

  }
  }

