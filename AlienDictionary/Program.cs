using System;
using System.Collections.Generic;

namespace AlienDictionary
{
  class Program
  {

    // https://leetcode.com/problems/alien-dictionary/


    static void Main(string[] args)
    {
      // string[] words = {"wrt", "wrf", "er", "ett", "rftt" };
      // string[] words = { "z", "x" };
      string[] words = { "z", "x" };
      BuildGraph(words);
      Console.WriteLine("What a wonderful World!");
    }

    static string BuildGraph(string[] words)
    {
      Stack<char> result = new Stack<char>();
      Dictionary<char, HashSet<char>> dict = new Dictionary<char, HashSet<char>>();
      bool[] visited= new bool[26];
      foreach (var word in words)
        foreach (char c in word)
        {
          if (!dict.ContainsKey(c))
            dict.Add(c, new HashSet<char>());
        }

      for (int i = 1; i < words.Length; i++)
      {
        string word1 = words[i - 1];
        string word2 = words[i];

        int length = Math.Min(word1.Length, word2.Length);
        for (int j = 0; j < length; j++)
        {
          if (word1[j] != word2[j])
            dict[word1[j]].Add(word2[j]);
        }
      }
      bool res = false;
      foreach (var entry in dict)
      {
        if (!visited[entry.Key - 'a'])
        {
          res = DFS(dict, entry.Key, visited, result);
        }
      }

      return "";
    }

    private static bool DFS(Dictionary<char, HashSet<char>> dict, char key, bool[] visited , Stack<char> result)
    {
      visited[key - 'a'] = true;
      foreach (var w in dict[key])
      {
        if (!visited[w - 'a'])
        {
          bool res = DFS(dict, w, visited, result);
          if (!res)
            return false;
        }
        else
          return false;
      }
      result.Push(key);
      return true;
    }
  }
}

/*
 There is a new alien language that uses the English alphabet. However, the order among the letters is unknown to you.

You are given a list of strings words from the alien language's dictionary, where the strings in words are sorted lexicographically by the rules of this new language.

Return a string of the unique letters in the new alien language sorted in lexicographically increasing order by the new language's rules. If there is no solution, return "". If there are multiple solutions, return any of them.

A string s is lexicographically smaller than a string t if at the first letter where they differ, the letter in s comes before the letter in t in the alien language. If the first min(s.length, t.length) letters are the same, then s is smaller if and only if s.length < t.length.

 

Example 1:

Input: words = ["wrt","wrf","er","ett","rftt"]
Output: "wertf"
Example 2:

Input: words = ["z","x"]
Output: "zx"
Example 3:

Input: words = ["z","x","z"]
Output: ""
Explanation: The order is invalid, so return "".
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 100
words[i] consists of only lowercase English letters. 
 */