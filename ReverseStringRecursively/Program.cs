using System;

namespace ReverseStringRecursively
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(ReverseString("  "));
      Console.WriteLine("Hello World!");
    }


    static string ReverseString(string s)
    {
      if (string.IsNullOrEmpty(s))
        return s;
      return ReverseString(s.Substring(1)) + s[0];
    }
  }
}
