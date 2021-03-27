using System;
using System.Collections.Generic;
using System.Linq;

namespace GetListOfCombinations
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
      int length = 3;
      GetCombinations(nums, length);
      Console.WriteLine("Hello World!");
    }

    static void GetCombinations(int[] nums, int length)
    {
      List<List<int>> combinationList = new List<List<int>>();

      int[] buffer = new int[length];
      PrintAndListCombinations(nums, buffer, 0, 0, combinationList);
      Console.Read();
    }

    static void PrintAndListCombinations(int[] nums, int[] buffer, int curIndex, int bufferIndex, List<List<int>> combinationList)
    {
      Console.WriteLine($"buffer: Combine({String.Join("-", buffer)}, curIndex = {curIndex}, bufferIndex = {bufferIndex} )");
      if (bufferIndex == buffer.Length)
      {
        Print(buffer);
        combinationList.Add(buffer.ToList<int>());
        return;
      }
      if (curIndex == nums.Length)
        return;

      for (int i = curIndex; i < nums.Length; i++)
      {
        buffer[bufferIndex] = nums[i];
        PrintAndListCombinations(nums, buffer, i + 1, bufferIndex + 1, combinationList);
      }
    
    }

    private static void Print(int[] buffer)
    {
      foreach (var c in buffer)
      {
        Console.Write(c + " ");
      }
      Console.WriteLine();
    }
  }
}
