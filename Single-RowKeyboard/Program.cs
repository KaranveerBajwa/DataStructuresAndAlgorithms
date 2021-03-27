using System;
using System.Collections.Generic;

namespace Single_RowKeyboard
{
  class Program
  {
    /*
     * There is a special keyboard with all keys in a single row.

Given a string keyboard of length 26 indicating the layout of the keyboard (indexed from 0 to 25).
    Initially, your finger is at index 0. To type a character, you have to move your finger to the index of the desired character.
    The time taken to move your finger from index i to index j is |i - j|.
    You want to type a string word. Write a function to calculate how much time it takes to type 
    it with one finger.
    Example:
    Input: keyboard = "abcdefghijklmnopqrstuvwxyz", word = "cba"
Output: 4
Explanation: The index moves from 0 to 2 to write 'c' then to 1 to write 'b' then to 0 again to write 'a'.
Total time = 2 + 1 + 1 = 4. 

    Example 2:
    Input: keyboard = "pqrstuvwxyzabcdefghijklmno", word = "leetcode"
Output: 73
     * */
    static void Main(string[] args)
    {
      string s = "abcdefghijklmnopqrstuvwxyz";
      string word = "cba";
      Console.WriteLine(CalculateTime(s, word));
      Console.WriteLine("On to next");
      string keyboard = "pqrstuvwxyzabcdefghijklmno";
      word = "leetcode";
      Console.WriteLine(CalculateTime(keyboard, word));

    }

    static int CalculateTime(string keyboard, string word)
    {
      if (word == null || word.Length == 0)
        return 0;
      Dictionary<char, int> keyLocs = new Dictionary<char, int>();
      PoplateDictionary(keyboard, keyLocs);

      int sum = Math.Abs(keyLocs[word[0]]);
      for (int i = 0; i < word.Length - 1; i++)
      {
        sum += Math.Abs(keyLocs[word[i]] - keyLocs[word[i + 1]]);
      }
      return sum;
    }

    private static void PoplateDictionary(string keyboard, Dictionary<char, int> keyLocs)
    {
      for (int i = 0; i < keyboard.Length; i++)
      {
        keyLocs.Add(keyboard[i], i);
      }
    }
  }
}
