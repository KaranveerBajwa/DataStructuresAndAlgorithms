using System;

namespace RecusrionChalteFirte
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"IS string abbcbba palindrome : {IsStringPalindrome("abbcbba")}");
      Console.WriteLine($"IS string abba palindrome : {IsStringPalindrome("abba")}");
      Console.WriteLine($"IS string geeks palindrome : {IsStringPalindrome("geeks")}");
      Console.WriteLine($"IS string a palindrome : {IsStringPalindrome("a")}");
      Console.WriteLine();

      Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(253)}");
      Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(9987)}");
      Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(10)}");
      Console.WriteLine($"Sum of all digits in numer : {SumOfAllDigitsInNumber(0)}");

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

  }
}
