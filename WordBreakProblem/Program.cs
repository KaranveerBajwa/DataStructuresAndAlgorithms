using System;
using System.Collections.Generic;

namespace WordBreakProblem
{
  class Program
  {
    static void Main(string[] args)
    {
      Dictionary<string, string> dict = new Dictionary<string, string>();
      dict.Add("i", "i");
      dict.Add("like", "like");
      dict.Add("mango", "mango");
      dict.Add("tango", "tango");
      string s = "ilikemangotango";
      var res = WordBreak(s, dict);
    }

    static string WordBreak(string s, Dictionary<string,string> dict)
    {
      List<string> breakdown = new List<string>();
      bool isBreakDownPossible = WordBreakHelper(s, 0,   breakdown, dict);
      return isBreakDownPossible ? String.Join(" ", breakdown) : "";
    }

    static bool WordBreakHelper(string s, int start, List<string> breakdown, Dictionary<string, string> dict)
    {
      if (start == s.Length)
        return true;

      for (int i = start; i < s.Length; i++)
      {
        string str = s.Substring(start, i- start + 1);
        if (dict.ContainsKey(str))
        {
          breakdown.Add(str);
          if (WordBreakHelper(s, i + 1, breakdown, dict))
            return true;
          else
            breakdown.RemoveAt(breakdown.Count - 1);
        }
       
      }
      return false;
    }

  }
}
