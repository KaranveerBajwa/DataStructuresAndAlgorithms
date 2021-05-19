using System;

namespace AllDivisorsOfNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintAllDivisors(100);
      PrintAllDivisors(7);
      PrinDivisorsEfficient(100);
      PrinDivisorsEfficient(7);
      Console.WriteLine("What a wonderful World!");
    }

    static void PrinDivisorsEfficient(int n)
    {
      for (int i = 1; i <= Math.Sqrt(n); i++)
      {
        if (n % i == 0)
        {
          Console.Write(i + " ");
          if(i != n/i)
            Console.Write(n / i  + " ") ;
        }
      }
      Console.WriteLine();
    }

    static void PrintAllDivisors(int n)
    {
      for (int i = 1; i <= n; i++)
      {
        if (n % i == 0)
          Console.Write(i + " ");
      }
      Console.WriteLine();
    }

  }
}
