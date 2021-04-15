using System;
using System.Collections.Generic;

namespace _20ValidParenthesis
{
  class Program
  {
    /*
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
      An input string is valid if:
      Open brackets must be closed by the same type of brackets.
      Open brackets must be closed in the correct order.
       https://leetcode.com/problems/valid-parentheses/
     */
    static void Main(string[] args)
    {
      Console.WriteLine(IsValid("()"));
      Console.WriteLine(IsValid("()[]{}"));
      Console.WriteLine(IsValid("(]"));
      Console.WriteLine(IsValid("([)]"));
      Console.WriteLine(IsValid("{[]}"));
      Console.WriteLine(IsValid(null));
      Console.WriteLine("What a wonderful world");
    }

    static bool IsValid(string s)
    {
      if (s == null)
        throw new ArgumentNullException("Input cannot be null");

      Stack<int> stack = new Stack<int>();

      for (int i = 0; i < s.Length; i++)
      {
        if (s[i] == ')' || s[i] == '}' || s[i] == ']')
        {
          if (stack.Count == 0 || s[i] != (char)stack.Peek())
            return false;
          stack.Pop();
        }
        else
        {
          switch (s[i])
          {
            case '(': 
              stack.Push(')');
              break;
            case '{':
              stack.Push('}');
              break;
            case '[':
              stack.Push(']');
              break;
            default:
              throw new ArgumentException("Input does not contain valid characters");
          }
        }
      }

     return stack.Count == 0 ? true : false;
    }
  }
}
