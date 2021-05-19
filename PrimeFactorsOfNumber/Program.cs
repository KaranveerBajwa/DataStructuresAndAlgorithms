using System;

namespace PrimeFactorsOfNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      PrintPrimeFactors(15);
      Console.WriteLine();
      PrintPrimeFactors(12);

      Console.WriteLine();
      PrintPrimeFactorsEfficient_1(84);
      Console.WriteLine();
      PrintPrimeFactorsEfficient_1(450);
      Console.WriteLine();
      PrintPrimeFactorsEfficient_1(13);
      Console.WriteLine();
      PrimeFactorsEfficient_2(84);
      Console.WriteLine();
      PrimeFactorsEfficient_2(450);
      Console.WriteLine();
      PrimeFactorsEfficient_2(13);
      Console.WriteLine("What a wonderful World!");
    }

    // divisors in pairs
    // a number n can be written as multiplication of powers of prime factor
      /*
       * check if number is divisible by 2 or 3 then they are prime factor
       * check for multiple of primefactors
       * loop from 5 to n and increment by 6
       *  check if n % i == 0 and (n % (i + 2) == 0)
       *    if not return false;
       */ 
    static void PrintPrimeFactorsEfficient_1(int n)
    {
      if (n <= 1)
        return;

      for (int i = 2; i <= Math.Sqrt(n); i++)
      {
        while (n % i == 0)
        {
          Console.Write(i + " ");
          n = n / i;          
        }
      }

      if(n > 1)
        Console.Write(n +" ") ;
    }

    // this can be made more efficient by explicityl checking for factors of 2 and 3
    // example the factors of number are
    //2 ,3 , 4, 5, 6,7 ,8,9,10,11,12,13,14,15,16,17,18,19,20,21,23,24,25,26,27,29,30,31,... Squareroot of n
    // if we explicitly check for factors of 2 and 3 in the number then we can reduce the number we have
    // to look for in loop then we have to look for 5, 7 then 11 ,13 then 17,19 then 23,29...

    static void PrimeFactorsEfficient_2(int n)
    {
      if (n <= 1)
        return;

      while (n % 2 == 0)
      {
        Console.Write(2 + " ");
        n = n / 2;
      }

      while (n % 3 == 0)
      {
        Console.Write(3 + " ");
        n = n / 3;
      }

      for (int i = 5; i < n; i = i + 6)
      {
        while (n % i == 0)
        {
          Console.Write(i + " ");
          n = n / i;
        }

        while (n % (i + 2) == 0)
        {
          Console.Write((i +2 )+ " ");
          n = n / (i+2);
        }
      }

    }



    static void PrintPrimeFactors(int n)
    {
      // from 2 to n
      // check if the number is factor and then if number is prime
      // check if there are multiple factors that appear in number , if yes print

      for (int i = 2; i < n; i++)
      {
        if (n % i == 0)
        {
          if (IsPrime(i))
          {
            int x = i;
            while (n % x == 0)
            {
              Console.Write(i + " ");
              x = x * i;  // to get the multiple factors of given number
            }
          }
        }
      }
    }

    static bool IsPrime(int n)
    {
      for (int i = 2; i <= Math.Sqrt(n); i++)
      {
        if (n % i == 0)
          return false;
      }
      return true;
    }

  }
}
