using System;

namespace FactorialOfNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Factorial(5));
      Console.WriteLine($"Recursive {Factorial(5)}");
      Console.WriteLine("What a wonderful World!");
    }

    static int Factorial(int n)
    {
      int res = 1;
      for (int i = 2; i <= n; i++)
        res = res * i;
      return res;      
    }


    static int FactorialRecursive(int n)
    {
      if (n <= 1)
        return 1;
      return n * FactorialRecursive(n - 1);
    
    }
  }
}
