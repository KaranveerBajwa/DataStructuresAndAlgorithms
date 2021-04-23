using System;

namespace LongestCommonSubstring
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(LCSubRecursiveString("abdca", "cbda"));
      Console.WriteLine(LCSubRecursiveString("passport", "ppsspt"));

      Console.WriteLine(LCSubstringBottomsUp("abdca", "cbda"));
      Console.WriteLine(LCSubstringBottomsUp("passport", "ppsspt"));


      Console.WriteLine(LCSubstringBottomsUp("abdca", "cbda"));
      Console.WriteLine(LCSubstringBottomsUp("passport", "ppsspt"));

      Console.WriteLine(LCSubstringTabulation("abdca", "cbda"));
      Console.WriteLine(LCSubstringTabulation("passport", "ppsspt"));

      Console.WriteLine("What a Wonderful World!");
    }


    static int LCSubstringBottomsUp(string s1, string s2)
    {
      int[,] dp = new int[s1.Length + 1, s2.Length + 1];
      for (int i = 0; i <= s1.Length; i++)
      {
        dp[i, 0] = 0;
      }
      for (int i = 0; i <= s2.Length; i++)
      {
        dp[0, i] = 0;
      }

      int maxLength = 0;
      for (int i = 1; i <= s1.Length; i++)
      {
        for (int j = 1; j <= s2.Length; j++)
        {
          if (s1[i - 1] == s2[j - 1])
          {
            dp[i, j] = 1 + dp[i - 1, j - 1];
             maxLength = Math.Max(maxLength, dp[i, j]);
          }
        }
      }
      return maxLength;
    }


    static string LCSubstringTabulation(string s1, string s2)
    {
      int[,] dp = new int[s1.Length + 1, s2.Length + 1];
      int rowEnd = 0;
      int colEnd = 0;

      for (int i = 0; i <= s1.Length; i++)
      {
        dp[i, 0] = 0;
      }
      for (int i = 0; i <= s2.Length; i++)
      {
        dp[0, i] = 0;
      }

      int maxLength = 0;
      for (int i = 1; i <= s1.Length; i++)
      {
        for (int j = 1; j <= s2.Length; j++)
        {
          if (s1[i - 1] == s2[j - 1])
          {
            dp[i, j] = 1 + dp[i - 1, j - 1];
            if (dp[i, j] > maxLength)
            {
              maxLength = dp[i, j];
              rowEnd = i;
              colEnd = j;

            }
          }
        }
      }
      string s = "";
      while (dp[rowEnd, colEnd] > 0)
      {
        s = s1[rowEnd - 1] + s;
        rowEnd = rowEnd - 1;
        colEnd = colEnd - 1;
      }

      Console.WriteLine($"the longest common substring is {s}");
      return s;
    }


    static int LCSubstringBottomUpOnSpace(string s1, string s2)
    {
      int[,] dp = new int[2, s2.Length+ 1];
      int maxLength = 0;

      for (int i = 1; i <= s1.Length; i++)
        for (int j = 1; j <= s2.Length; j++)
        {
          dp[i % 2, j] = 0;
          if (s1[i - 1] == s2[j - 1])
          {
            dp[i % 2, j] = 1 + dp[(i - 1) % 2, j-1];
            maxLength = Math.Max(dp[i%2, j], maxLength);
          }
        }
      return maxLength;
    }

    static int LCSubRecursiveString(string s1, string s2)
    {
      return LCSubstringRecursiveHelper(s1, s2, 0, 0, 0);
    }

    static int LCSubstringRecursiveHelper(string s1, string s2, int i1, int i2, int count)
    {
      // Console.WriteLine($" LCSubstringHelper(string {s1}, string {s2}, int {m}, int {n}, int {count})");
      if (i1 == s1.Length || i2 == s2.Length)
        return count;


      if (s1[i1] == s2[i2])
        count = LCSubstringRecursiveHelper(s1, s2, i1 + 1, i2 + 1, count + 1);

      int c1 = LCSubstringRecursiveHelper(s1, s2, i1, i2 + 1, 0);
      int c2 = LCSubstringRecursiveHelper(s1, s2, i1 + 1, i2, 0);

      return Math.Max(count, Math.Max(c1, c2));
    }

  }
}
