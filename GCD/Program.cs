using System;

namespace GreatestCommonDivisor
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(GCD(1,49));
      Console.WriteLine("What a wonderful World!");
    }

    static int GCD(int a, int b)
    {
      if (a == 0 || b == 0)
        throw new ArgumentException("Input cannot be 0");
      while (a != b)
      {
        if (a > b)
          a = a - b;
        else
          b = b - a;
      }
      return a;
    }
  }
}
