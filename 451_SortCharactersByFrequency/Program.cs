using System;
using System.Text;
using System.Collections.Generic;

namespace _451_SortCharactersByFrequency
{
  /*
   * Given a string s, sort it in decreasing order based on the frequency of characters, and return the sorted string.
Example 1:
Input: s = "tree"
Output: "eert"
Explanation: 'e' appears twice while 'r' and 't' both appear once.
So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
Example 2:
Input: s = "cccaaa"
Output: "aaaccc"
Explanation: Both 'c' and 'a' appear three times, so "aaaccc" is also a valid answer.
Note that "cacaca" is incorrect, as the same characters must be together.

Example 3:
Input: s = "Aabb"
Output: "bbAa"
Explanation: "bbaA" is also a valid answer, but "Aabb" is incorrect.
Note that 'A' and 'a' are treated as two different characters.
 
   */
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(FrequencySort("Aaaabbbcc"));
      Console.WriteLine("Hello World!");
      

    }

    static string FrequencySort(string s)
    {
      StringBuilder sb = new StringBuilder();
      if (s == null || s.Length == 0)
        return s;
      Dictionary<char, int> dict = new Dictionary<char, int>();
      foreach (char c in s)
      {
        if (!dict.ContainsKey(c))
          dict.Add(c, 0);
        dict[c]++;        
      }

      MaxHeap heap = new MaxHeap(dict.Count);
      foreach (var entry in dict)
      {
        heap.Insert(new CharFreqInfo(entry.Key, entry.Value));
      }

      while (heap.Count > 0)
      {
        var cInfo = heap.Delete();
        for (int i = 0; i < cInfo.Count; i++)
        {
          sb.Append(cInfo.Char);
        }
      }
      return sb.ToString();
    }
  }

  public class MaxHeap
  {
    public int Count;
    public CharFreqInfo[] charFrequencies;

    public MaxHeap(int size)
    {
      charFrequencies = new CharFreqInfo[size + 1];
      Count = 0;
    }

    public void Insert(CharFreqInfo cInfo)
    {
      charFrequencies[++Count] = cInfo;
      Swim(Count);
    }

    public CharFreqInfo Delete()
    {
      var cInfo = charFrequencies[1];
      Swap(1, Count);
      Count = Count - 1;
      Sink(1);
      return cInfo;
    }

    private void Swim(int k)
    {
      int j = k / 2;
      while (j >= 1 && charFrequencies[k].Count > charFrequencies[j].Count)
      {
        Swap(j, k);
        k = j;
        j = j / 2;
      }
    }

    private void Sink(int k)
    {
      int j = 2 * k;
      while (j <= Count)
      {
        if (j < Count && charFrequencies[j].Count < charFrequencies[j + 1].Count)
          j = j + 1;
        if (charFrequencies[k].Count > charFrequencies[j].Count)
          break;
        Swap(j, k);
        k = j;
        j = 2 * k;

      }
    
    }

    private void Swap(int i, int j)
    {
      CharFreqInfo cInfo = charFrequencies[i];
      charFrequencies[i] = charFrequencies[j];
      charFrequencies[j] = cInfo;
    }

  }

  public class CharFreqInfo
  {
    public char Char;
    public int Count;

    public CharFreqInfo(char c, int count)
    {
      Char = c;
      Count = count;
    }  
  }
}
