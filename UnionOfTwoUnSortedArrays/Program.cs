using System;
using System.Collections.Generic;

namespace UnionOfTwoUnSortedArrays
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(UnionOfUnSortedArrays(new int[] { 15, 20, 5, 15 }, new int[] { 15, 15, 15, 20, 10 }));
      Console.WriteLine(UnionOfUnSortedArrays(new int[] {10,12,15 }, new int[] {18,12 }));
      Console.WriteLine(UnionOfUnSortedArrays(new int[] { 3,3,3}, new int[] { 3,3}));
      Console.WriteLine("What a wonderful World!");
    }

    static int UnionOfUnSortedArrays(int[] arr1, int[] arr2)
    {
      HashSet<int> hs = new HashSet<int>();
      for (int i = 0; i < arr1.Length; i++)
      {
        hs.Add(arr1[i]);
      }

      for (int i = 0; i < arr2.Length; i++)
      {
        hs.Add(arr2[i]);
      }
      return hs.Count;
    }
  }
}
