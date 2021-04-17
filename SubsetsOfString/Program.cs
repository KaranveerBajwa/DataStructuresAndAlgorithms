using System;

namespace SubsetsOfString
{
  /*
   * there will be 2 raised power n subsets in a string
   */ 
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("What a wonderfull World!");
      string str = "ABCD";
      FindSubsets(str);
      FindSubsetsWithoutChangingOriginal(str);
    }

    static void FindSubsets(string str)
    {
      FindSubsets("", str);
    }

    static void FindSubsets(string soFar, string remaining)
    {
      if (remaining.Length == 0)
      {
        Console.WriteLine(soFar);
        return;
      }
      FindSubsets(soFar + remaining[0], remaining.Substring(1));
      FindSubsets(soFar, remaining.Substring(1));
    }

    static void FindSubsetsWithoutChangingOriginal(string s)
    {
      FindSubsetsWithoutChangingOriginalHelper(s, "", 0);
    }

    static void FindSubsetsWithoutChangingOriginalHelper(string s, string soFar, int index)
    {
      if (index == s.Length)
      {
        Console.WriteLine(soFar);
        return;
      }
      FindSubsetsWithoutChangingOriginalHelper(s, soFar + s[index], index + 1);
      FindSubsetsWithoutChangingOriginalHelper(s, soFar, index + 1);
    }

  }
}
