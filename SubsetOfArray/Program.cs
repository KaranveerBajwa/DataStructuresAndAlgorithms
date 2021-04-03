using System;
using System.Collections.Generic;

namespace SubsetOfArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[] arr = { 12, 34, 56, 78 };
      PrintSubsets(arr);
    }

    static void PrintSubsets(int[] arr)
    {
      List<int> subSet = new List<int>();
      PrintSubsets(arr, subSet , 0);
    }

    static void PrintSubsets(int[] arr, List<int> subSet, int index)
    {
      if (index == arr.Length)
      {
        PrintList(subSet);
      }
      else
      {
        subSet.Add(arr[index]);
        PrintSubsets(arr,subSet , index + 1);
        subSet.RemoveAt(subSet.Count - 1);
        PrintSubsets(arr, subSet, index + 1);
      }

    }

    private static void PrintList(List<int> subSet)
    {
      Console.WriteLine(String.Join(",", subSet));
    }
  }
}
