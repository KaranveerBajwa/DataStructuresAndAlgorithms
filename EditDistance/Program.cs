using System;

namespace EditDistance
{
  class Program
  {
    /*
     * Clarifications needed:
      * is it case sensitice or 'A' and 'a' are equal 
     * 
     * Given two strings word1 and word2, return the minimum number of operations required to convert word1 to word2.
You have the following three operations permitted on a word:
  Insert a character
  Delete a character
  Replace a character

    Example 1:
Input: word1 = "horse", word2 = "ros"
Output: 3
Explanation: 
horse -> rorse (replace 'h' with 'r')
rorse -> rose (remove 'r')
rose -> ros (remove 'e')
    
Example 2:
Input: word1 = "intention", word2 = "execution"
Output: 5
Explanation: 
intention -> inention (remove 't')
inention -> enention (replace 'i' with 'e')
enention -> exention (replace 'n' with 'x')
exention -> exection (replace 'n' with 'c')
exection -> execution (insert 'u')
 */
    static void Main(string[] args)
    {
      Console.WriteLine(MinimumEdits("CAT","CUT"));
      Console.WriteLine(MinimumEdits("Saturday", "Sunday"));
      Console.WriteLine();
      Console.WriteLine(MinimumEditsTabulation("CAT", "CUT"));
      Console.WriteLine(MinimumEditsTabulation("Saturday", "Sunday"));
      Console.WriteLine("What a wonderful World!");

    }

    static int MinimumEditsTabulation(string s1, string s2)
    {
      int[,] dp = new int[s1.Length + 1, s2.Length + 1];
      for (int i = 0; i < s1.Length; i++)  // number of deletes equal to length of s1 as s2 is empty
        dp[i, 0] = i;
      for (int j = 0; j <= s2.Length; j++) // number of insert equal to length of string s2
        dp[0, j] = j;

      for (int i = 1; i <= s1.Length; i++)
        for (int j = 1; j <= s2.Length; j++)
        {
          if (s1[i - 1] == s2[j - 1])
            dp[i, j] = dp[i - 1, j - 1];
          else
            dp[i, j] = 1 + Math.Min(
                dp[i - 1, j] // delete the character from string s1
                , Math.Min(dp[i, j - 1] // insert the character from s2 to s1
                , dp[i - 1, j - 1] // replace the character from s2 in s1
              ));
        }
      return dp[s1.Length, s2.Length];
    }

    static int MinimumEdits(string s1, string s2)
    {
      // if the comparision is case insensitive we can convert both strings to lower case before calling the helper method
      return MinimumEditsHelper(s1, s2, s1.Length , s2.Length );
    }

    static int MinimumEditsHelper(string s1, string s2, int m, int n)
    {
      if (m == 0) // string s1 is empty then we need to insert all characters from s2 to s1 (n)
        return n ;

      if (n == 0) // string s2 is empty then we need to delete all characters from s1 (m)
        return m;

      if (s1[m - 1] == s2[n - 1])
        return MinimumEditsHelper(s1, s2, m - 1, n - 1); // move left for both both strings no count change

      return 1 + Math.Min(
        MinimumEditsHelper(s1, s2, m, n-1) // insert last character from s2  in s1
        ,Math.Min(MinimumEditsHelper(s1, s2, m-1, n) // delete the last character in string s1  // as Math.Min compares only two
        , MinimumEditsHelper(s1, s2, m-1, n-1)) // replace the last character from s2 in s1
        );    
    }

  }
}
