using System;
using System.Collections.Generic;

namespace CommonDistinctElementsInTwoArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(CountCommonElements(new int[] { 10, 15, 20, 5, 30 }, new int[] { 30, 5, 30, 80 }));
      Console.WriteLine(CountCommonElements(new int[] {10,20 }, new int[] { 20,30}));
      Console.WriteLine(CountCommonElements(new int[] { 10,10,10}, new int[] { 10,10,10}));
      Console.WriteLine("What a wonderful World!");
    }

    static int CountCommonElements(int[] arr1, int[] arr2)
    {
      HashSet<int> hs = new HashSet<int>();
      int count = 0;
      for (int i = 0; i < arr1.Length; i++)
      {
        hs.Add(arr1[i]);
      }

      for (int i = 0; i < arr2.Length; i++)
      {
        if (hs.Contains(arr2[i]))
        {
          count++;
          hs.Remove(arr2[i]);
        }
      }
      return count;
    }
  }
}
