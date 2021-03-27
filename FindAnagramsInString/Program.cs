using System;
using System.Collections.Generic;
namespace FindAnagramsInString
{
  class Program
  {
    // Leetcode problem: 438 https://leetcode.com/problems/find-all-anagrams-in-a-string/
    static void Main(string[] args)
    {
      string s = "abab";
      string p = "ab";
      HashSet<char> h = new HashSet<char>(p);
      Console.WriteLine(String.Join(",", GetAnagramStartPositionsIfUnique(s, p)));    
    }

    static IEnumerable<int> GetAnagramStartPositionsIfUnique(string s, string p)
    {
      int start = 0;
      int current = start;
      int end = s.Length - p.Length;
      List<int> results = new List<int>();
      HashSet<char> hs = new HashSet<char>(p);
      while (start <= end)
      {
        if (hs.Contains(s[current]))
        {
          hs.Remove(s[current]);
          if (hs.Count == 0)
          {
            results.Add(start);
            start++;
            current = start;
            hs = new HashSet<char>(p);
          }
          else
          {
            current++;
          }
        }
        else
        {
          hs = new HashSet<char>(p);
          start++;
          current = start;
        }
      }
      return results;
    }

    //static IEnumerable<int> GetAnagramPositionsWithDuplicates(string s, string p)
    //{
    //  List<int> result = new List<int>();
    //}
  
  }
}
