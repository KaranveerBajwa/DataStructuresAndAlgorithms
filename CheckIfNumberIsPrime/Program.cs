using System;

namespace CheckIfNumberIsPrime
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(IsPrime(5));
      Console.WriteLine(IsPrime(8));
      Console.WriteLine(IsPrime(19));
      Console.WriteLine(IsPrime(0));
      Console.WriteLine(IsPrime(9));

      Console.WriteLine("What a wonderful World!");
    }

    static bool IsPrime(int n)
    {
      int end = (int)Math.Sqrt(n);
      for (int i = 2; i <= end; i++)
      {
        if (n % i == 0)
          return false;
      }
      return true;
    }

  }
}
