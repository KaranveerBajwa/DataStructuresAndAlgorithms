using System;

namespace SomeBasicRecursion
{
  class Program
  {
    static void Main(string[] args)
    {


      //int input1 = 0;
      //Console.WriteLine($"Number of digits in {input1} are {CountDigits(input1)}");
      //Console.WriteLine($"Sum of digits in {input1} is {SumOfDigits(input1)}");
      //int input2 = 9999;
      //Console.WriteLine($"Number of digits in {input2} are {CountDigits(input2)}");
      //Console.WriteLine($"Sum of digits in {input2} is {SumOfDigits(input2)}");

      //int input3 = 1000;
      //Console.WriteLine($"Number of digits in {input3} are {CountDigits(input3)}");
      //Console.WriteLine($"Sum of digits in {input3} is {SumOfDigits(input3)}");


      //printNos(10);

      Console.WriteLine(TheSequence(2));
      Console.WriteLine(TheSequence(3));

      Console.WriteLine("What a wonderful World!");
    }
    public static void printNos(int N)
    {
      printNumsHelper(N, 1); 
      //Your code here
    }

    static void printNumsHelper(int N, int index)
    {
      if (index > N)
        return;
      Console.Write(index + " ");
      printNumsHelper(N, index + 1);

    }

    static int CountDigits(int num)
    {
      if (num < 10)
        return 1;
      return 1 + CountDigits(num / 10);
    }

    static int SumOfDigits(int num)
    {
      if (num < 10)
        return num;

      return num % 10 + SumOfDigits(num / 10);
    }
    /*
     * S that is given by:
      S(n) = n+ n* (S(n-1)) and S(0) = 1 
     */
    static int TheSequence(int n)
    {
      if (n == 0)
        return 1;
      return n + n * TheSequence(n - 1);

    }
  }
}
