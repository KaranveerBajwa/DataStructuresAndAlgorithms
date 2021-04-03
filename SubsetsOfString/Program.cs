using System;

namespace SubsetsOfString
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      string str = "ABCD";
      FindSubsets(str);
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
  }
}
