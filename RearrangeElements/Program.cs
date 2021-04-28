using System;
using System.Collections.Generic;
using System.Text;

namespace RearrangeStrings
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = "Programming";
      Console.WriteLine(RearrangeString(str));
      Console.WriteLine(RearrangeString("aapa"));
      Console.WriteLine(RearrangeString("aappp"));

      Console.WriteLine("What a wonderful World!");
    }
    // create a dictionary with character and frequency
    // Create a MaxHeap
    // get the top element add to the string and decrement the count
    // do not push it back get the next element , 
    // push the previous string back to heap if count >0 and heap is not empty

    static string RearrangeString(string str)
    {
      Dictionary<char, int> dict = new Dictionary<char, int>();

      foreach (char c in str)
      {
        if (!dict.ContainsKey(c))
          dict.Add(c, 0);
        dict[c]++;      
      }
      MaxHeap maxHeap = new MaxHeap(dict.Count);

      foreach (var entry in dict)
      {
        maxHeap.Insert(new Element(entry.Key, entry.Value));
      }
      Element previous = null;
      Element current = null;
      StringBuilder sb = new StringBuilder();
      while (maxHeap.Count > 0)
      {
        current = maxHeap.Delete();
        if (previous != null && previous.Frequency > 0)
          maxHeap.Insert(previous);
        sb.Append(current.Character);
        current.Frequency--;
        previous = current;
      }


      return sb.Length == str.Length ? sb.ToString() : "";
    }

  
  }

  public class Element
  {
    public char Character;
    public int Frequency;

    public Element(char c, int freq)
    {
      Character = c;
      Frequency = freq;
    }
  }
  /*
   * Given a string, find if its letters can be rearranged in such a way that no two same characters come next to each other.

Example 1:

Input: "aappp"
Output: "papap"
Explanation: In "papap", none of the repeating characters come next to each other.
Example 2:

Input: "Programming"
Output: "rgmrgmPiano" or "gmringmrPoa" or "gmrPagimnor", etc.
Explanation: None of the repeating characters come next to each other.
Example 3:

Input: "aapa"
Output: ""
Explanation: In all arrangements of "aapa", atleast two 'a' will come together e.g., "apaa", "paaa".
   */
}
