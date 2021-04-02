using System;
using System.Collections.Generic;

namespace CountVowels
{
  class Program
  {
    static void Main(string[] args)
    {
      string vowels = "AEIOUaeiou";
      HashSet<char> hs = new HashSet<char>(vowels);

      Console.WriteLine(CountVowels("HelloWorld", 0, hs));
      Console.WriteLine(CountVowels("str", 0, hs));
      Console.WriteLine(CountVowels("AEIOUaeiou", 0, hs));
      Console.WriteLine("Hello World!");
    }

    static int CountVowels(string text, int index, HashSet<char> vowels)
    {
      int count = 0;
      if (index == text.Length)
        return 0;

      if (vowels.Contains(text[index]))
        count++;
      Console.WriteLine($"Char : {text[index]}, {count}");
        return count + CountVowels(text,  index + 1, vowels);
    }
  }
}
