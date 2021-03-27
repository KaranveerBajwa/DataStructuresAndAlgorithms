using System;

namespace CheckForPrime
{
  class Program
  {
    static void Main(string[] args)
    {
      int num = 12;
      Console.WriteLine(IsPrime(num));
      Console.WriteLine("Hello World!");
    }

    static bool IsPrime(int num)
    {
      return IsPrime(num, (int)num / 2);
    }

    static bool IsPrime(int num, int i)
    {
      if (i == 1)
        return true;

      if (num % i == 0)
        return false;
      return IsPrime(num, i - 1);

    }
  }
}
