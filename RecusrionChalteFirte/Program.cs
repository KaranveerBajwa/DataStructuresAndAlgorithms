using System;

namespace RecusrionChalteFirte
{
  class Program
  {
    /*
    Problems done:
    1. Factorial
    2. Print 1 to N
    3. Is string Palindrome
    4. Summ of all digits in number
    5. Fibonacci Series
    6. The sequence 
        You are given a number n. You need to recursively find the nth term of the series S that is given by:
        S(n) = n+ n*(S(n-1)) and S(0) = 1
    7.
    8. Check number is palindrome if 100 false if 101 true
    9. GCD Euclid
    10. Print array elements with recursion

     */
    static void Main(string[] args)
    {



      //Console.WriteLine($"IS string abbcbba palindrome : {IsStringPalindrome("abbcbba")}");
      //Console.WriteLine($"IS string abba palindrome : {IsStringPalindrome("abba")}");
      //Console.WriteLine($"IS string geeks palindrome : {IsStringPalindrome("geeks")}");
      //Console.WriteLine($"IS string a palindrome : {IsStringPalindrome("a")}");
      //Console.WriteLine();

      //Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(253)}");
      //Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(9987)}");
      //Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(10)}");
      //Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(0)}");

      //Console.WriteLine(Factorial(3));
      //Console.WriteLine(Factorial(5));
      //Console.WriteLine(Factorial(0));


      // Print1ToN(10);

      //Console.WriteLine(RecursiveSum(5));
      //Console.WriteLine(RecursiveSum(4));

      //Console.WriteLine(Fibonacci(1));
      //Console.WriteLine(Fibonacci(20));

      //Console.WriteLine(TheSequence(2));
      //Console.WriteLine(TheSequence(3));

      //Console.WriteLine(IsNumberPalindrome(100));
      //Console.WriteLine(IsNumberPalindrome(101));
      //Console.WriteLine(IsNumberPalindrome(222));

      //TODO: use calculation(simplify the formula) before sending the recurisive function on way to calculate factorial
      //Console.WriteLine(GetFactorial(13, 11));
      //Console.WriteLine(GetFactorial(4,4));

      //Console.WriteLine(GCD(7, 8));
      //Console.WriteLine(GCD(2, 4));

      PrintArrayRecursively(new int[] { 1, 2, 3, 4, 5 }, 5);
      Console.WriteLine();
      PrintArrayRecursively(new int[]{ 5,4,2,1}, 4);
      Console.WriteLine();
      Console.WriteLine("What a wonderful World!");
    }


    static bool IsStringPalindrome(string s)
    {
      // start from both ends and compare characters 
      // if they are not equal return false
      // if you have left greater than right , then return true

      int left = 0;
      int right = s.Length - 1;
      return IsStringPalindromeHelper(s, left, right);    
    }

    static bool IsStringPalindromeHelper(string s, int left, int right)
    {
      if (left >= right)
        return true;

      return s[left] == s[right] && IsStringPalindromeHelper(s, left + 1, right - 1);


    }


    static int SumOfAllDigitsInNumber(int n)
    {
      if (n == 0)
        return 0;

      return n % 10 + SumOfAllDigitsInNumber(n / 10);
    
    }

    static void Print1ToN(int n)
    {
      if (n == 0)
        return;
      Print1ToN(n - 1);
      Console.Write(n + " ");
      
    }

    static  uint  Factorial(uint n)
    {
      if(n <=1)
      { 
        return n;
      }

      return n * Factorial(n - 1);

    }

    static int CountDigits(int n)
    {
      if (n <= 9)
      {
        return 1;
      }

      return 1 + CountDigits(n / 10);
    
    }

    static int RecursiveSum(int n)
    {
      if (n == 0)
        return 0;

      return n + RecursiveSum(n - 1);

    }

    static int Fibonacci(int n)
    {
      if (n <= 0)
        return 0;
      if (n <= 2)
        return 1;

      return Fibonacci(n - 1) + Fibonacci(n - 2);

    
    }

    static int TheSequence(int n)
    {
      if (n == 0)
        return 1;

      return n + n * TheSequence(n - 1);
        
    }

    static bool IsNumberPalindrome(int n)
    {
      return n == GetNumberInReverse(n,0);
    }

    private static int GetNumberInReverse(int n, int num)
    {
      if (n == 0)
        return num;
      num = 10 * num + n % 10 ;
      return GetNumberInReverse(n / 10, num);

    }

    static int GetFactorial(uint n, uint r)
    {
      if (n == 1 || n == r)
        return 1;

      return Convert.ToInt32(Factorial(n) / (Factorial(n - r) * Factorial(r)));
    }

    static int GCD(int a, int b)
    {
      Console.WriteLine($"GCD({a}, {b})");
      if (a == b)
        return a;

      if (a > b)
        return GCD(a - b, b);
      else
        return GCD(b - a, a);    
    }

    static void PrintArrayRecursively(int[] arr, int n)
    {
      if (n == 0)
        return;

      PrintArrayRecursively(arr, n - 1);
      Console.Write(arr[n-1] + " ");
    }
  
  }
}
