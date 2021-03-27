using System;

namespace ConvertDecimalToBinary
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(DecimalToBinary(1));
      Console.WriteLine(DToB(9));
      Console.WriteLine("Hello World!");
    }
    // if number == 1 return 1

    static string DecimalToBinary(int num)
    {
      if (num == 0)
        return "0";
      if (num == 1)
        return "1";
      return DecimalToBinary(num / 2) + num % 2;

    }

    static int DToB(int num)
    {
      if (num == 0 || num == 1)
        return num;
      return (num % 2) + 10 * DToB(num / 2);
    }

  }
}
