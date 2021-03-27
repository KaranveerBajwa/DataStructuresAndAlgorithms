using System;

namespace ReverseSentence
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(ReverseString("Sky is Blue"));
      Console.WriteLine("Hello World!");
    }

    static string ReverseString(string s)
    {
      char[] str = new char[s.Length];
      int start = s.Length - 1;
      int insertIndex = 0;
      int end;
      while (insertIndex <= s.Length-1)
      {
        end = start;
        while (start >= 0 && s[start] != ' ' )
          start--;
        int i = start + 1;
        while (i <= end)
        {
          str[insertIndex++] = s[i++];
        }

        if(start >=0)
        {
          str[insertIndex++] = s[start];
          start--;
        }
      }
      return new string(str);    
    }
  }
}
