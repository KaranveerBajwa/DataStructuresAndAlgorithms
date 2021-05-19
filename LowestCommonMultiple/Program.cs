using System;

namespace LowestCommonMultiple
{
  class Program
  {
    // product of two numbers = LCM * GCD
    // 12 * 15 = 60 * 3
    // to get LCM

    static void Main(string[] args)
    {
      Console.WriteLine($"LCM is {LCM(12, 15)}");
      Console.WriteLine($"LCM is {LCM(2, 8)}");
      Console.WriteLine($"LCM is {LCM(7, 3)}");
      Console.WriteLine("What a wonderful World!");
    }

    static int LCM(int num1, int num2)
    {
      if (num1 == 0 || num2 == 0)
        return 0;
      int gcd = GCD(num1, num2);
      return (num1 * num2) / gcd;
    }

    static int GCD(int num1, int num2)
    {
      while (num1 != num2)
      {
        if (num1 > num2)
          num1 = num1 - num2;
        else
          num2 = num2 - num1;
      }
      return num1;
    
    }
  }
}
