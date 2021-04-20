using System;

namespace FibonacciNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Fib(2));
      Console.WriteLine(Fib(4));
      Console.WriteLine(Fib(3));
      Console.WriteLine(Fib(0));

      Console.WriteLine("What a wonderful World!");
    }

    public static int Fib(int n)
    {
      int result = 0;
      if (n <= 1)
        return n;

      int f1 = 0;
      int f2 = 1;
      for (int i = 2; i <= n; i++)
      {
        result = f1 + f2;
        f1 = f2;
        f2 = result;
      }
      return result;
    }
  }
}
