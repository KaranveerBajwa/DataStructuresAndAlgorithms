using System;

namespace RemoveDupicatesInString
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Remove("HHeHellllooo Worlllld"));
      Console.WriteLine(RemoveDups("HHeHellllooo Worlllld"));
      Console.WriteLine("Hello World!");
    }

    static string Remove(string s)
    {
      if (s == null)
        return s;
      char c = (char) (s[0] + '1');
      return RemoveDuplicates(s, c);
    }

    static string RemoveDups(string s)
    {
      if (string.IsNullOrEmpty(s))
        return s;
      if (s.Length == 1)
        return s;
      if (s[0] == s[1])
       return RemoveDups(s.Substring(1));
      else
        return s[0] + RemoveDups(s.Substring(1));
    }


    static string RemoveDuplicates(string s, char c)
    {
      if (s.Length == 0)
        return s;
      if (c == s[0])
        return RemoveDuplicates(s.Substring(1), c);
      else {
        c = s[0];
        return s[0] + RemoveDuplicates(s, c);
      }

    }
  }
}
