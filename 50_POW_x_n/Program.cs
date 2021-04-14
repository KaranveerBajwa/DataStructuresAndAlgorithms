﻿using System;

namespace _50_POW_x_n
{
  /*
   * Implement pow(x, n), which calculates x raised to the power n (i.e., xn).

Example 1:
Input: x = 2.00000, n = 10
Output: 1024.00000
  
 Example 2:
Input: x = 2.10000, n = 3
Output: 9.26100
  
Example 3:
Input: x = 2.00000, n = -2
Output: 0.25000
Explanation: 2-2 = 1/22 = 1/4 = 0.25
*/
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(MyPow(0,-10));
      Console.WriteLine(MyPow(2.00, -2));
      Console.WriteLine(MyPow(-2.100, 3));

      Console.WriteLine("What a wonderful World!");
    }

    static double MyPow(double x, int n)
    {
      if (x == 0)
        return x;

      double result = Pow(x, n);
      return n < 0 ? 1 / result : result;
    }

    static double Pow(double x, int n)
    {
      if (n == 0)
        return 1;

      double res = Pow(x, n / 2);

      if (n % 2 != 0)
      {
        return x * res * res;
      }
      else
      {
        return res * res;
      }    
    }


  }
}
