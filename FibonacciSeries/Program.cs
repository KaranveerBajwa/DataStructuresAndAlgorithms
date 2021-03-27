using System;

namespace FibonacciSeries
{
  class Program
  {
    static void Main(string[] args)
    {
      int n = 5;
      for (int i = 0; i < 5; i++)
      {
        Console.Write(FibonacciNumber(i) + " ");
      }
    }

    static int FibonacciNumber(int n)
    {
      if (n == 0 || n == 1)
        return 1;
      return FibonacciNumber(n - 1) + FibonacciNumber(n - 2);
    }
  }
}
