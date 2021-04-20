using System;
using System.Text;

namespace RemoveDuplicatesInstring_II
{
  class Program
  {
    /*
     * You are given a string s and an integer k, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them, causing the left and the right side of the deleted substring to concatenate together.
    We repeatedly make k duplicate removals on s until we no longer can.
    Return the final string after all such duplicate removals have been made. It is guaranteed that the answer is unique.

Example 1:
Input: s = "abcd", k = 2
Output: "abcd"
Explanation: There's nothing to delete.
Example 2:
Input: s = "deeedbbcccbdaa", k = 3
Output: "aa"
Explanation: 
First delete "eee" and "ccc", get "ddbbbdaa"
Then delete "bbb", get "dddaa"
Finally delete "ddd", get "aa"
Example 3:

Input: s = "pbbcggttciiippooaais", k = 2
Output: "ps"
     * */
    static void Main(string[] args)
    {
       Console.WriteLine(RemoveDuplicates("d", 3));
      Console.WriteLine(RemoveDuplicates("yfttttfbbbbnnnnffbgffffgbbbbgssssgthyyyy",4 ));
      Console.WriteLine("What a wonderful World!");
    }

    static string RemoveDuplicates(string s, int k)
    {
      if (s == null)
        throw new ArgumentNullException("Input string cannot be null");
      StringBuilder sb ;
      int count = 1;
      int i;
      while (true)
      {
        sb = new StringBuilder();
        for (i = 1; i < s.Length; i++)
        {
          if (s[i] == s[i - 1])
            count++;
          else
          {
            if (count == k)
            {
              count = 1;
            }
            else if (count < k)
            {
              sb.Append(s.Substring(i - count, count));
              count = 1;
            }
            else  if (count > k)
              {
                count = count - k;
                sb.Append(s.Substring(i - count, count));
              }
            }
          }
        if (count >= k)
          count = count - k;
        sb.Append(s.Substring(i - count, count));
        count = 1;
        if (sb.Length == s.Length)
          break;
        
        s = sb.ToString();
      }
      return sb.ToString();
    }
  }
}
