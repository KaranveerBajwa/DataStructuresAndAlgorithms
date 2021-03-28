using System;
using System.Globalization;

namespace PalindromicSubstrings
{
  /*
   *
   *Given a string, your task is to count how many palindromic substrings in this string.
   *The substrings with different start indexes or end indexes are counted as different substrings even they consist of same characters.

Example 1:
Input: "abc"
Output: 3
Explanation: Three palindromic strings: "a", "b", "c".
 
Example 2:
Input: "aaa"
Output: 6
Explanation: Six palindromic strings: "a", "a", "a", "aa", "aa", "aaa".
Note:

The input string length won't exceed 1000.
Todo: Return the substrings
*/
  class Program
  {
    static void Main(string[] args)
    {
      string s = "aaa";
      Console.WriteLine(CountSubstring(s));
    }

    static int CountSubstring(string s)
    {
      int count = 0;
      for (int i = 0; i < s.Length; i++)
      {
        int left = i;
        int right = i;
        while (left >= 0 || right < s.Length)
        {
          if(left <0 )
          if (s[left] == s[right])
          {
            count++;
          }
          else
            break;
          if (left >= 0 && right < s.Length)
          {
            left--;
            right++;
          }
          else if (left > 0)
          {
            left--;
          }
          else if (right < s.Length-1)
            right++;


        }
      }
      return count;
    }
  }
}
