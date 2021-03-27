using System;

namespace FindGCD
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1 = 54;
      int num2 = 36;
      if (num1 < num2)
        Console.WriteLine(GCD(num2, num1));
      else
        Console.WriteLine(GCD(num1, num2));

      Console.WriteLine(GCDWithSubtraction(num1, num2));
      Console.WriteLine("Hello World!");

    }

    static int GCD(int num1, int num2) // 54, 36
    {
      if (num2 == 0)
        return num1;
        return GCD(num2, num1 % num2); // 36, 18    
    }

    static int GCDWithSubtraction(int num1, int num2)
    {
      if (num1 == num2)
        return num2;
      if (num1 > num2)
        return GCDWithSubtraction(num1 - num2, num2);
      else
        return GCDWithSubtraction(num2 - num1, num1);
    }
  }
}
