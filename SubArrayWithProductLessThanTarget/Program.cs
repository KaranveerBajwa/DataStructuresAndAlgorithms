using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace SubArrayWithProductLessThanTarget
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 2, 5, 3, 10 };
      int target = 30;
      PrintList(nums, target);

      PrintList(new int[] { 8, 2, 6, 5 }, 50);
      Console.WriteLine("What a wonderful World!");
    }

    private static void PrintList(int[] nums, int target)
    {
      List<List<int>> list = new List<List<int>>();
      int product = 1;
      int left = 0;
      for (int right = 0; right < nums.Length; right++)
      {
        product = product * nums[right];
        while (product >= target && left < nums.Length)
          product = product / nums[left++];

        for (int i = right; i >= left; i--)
        {
          AddRange(nums, i, right, list);
        }
      }
    }

    private static void AddRange(int[] arr, int start, int right, List<List<int>> result)
    {
      List<int> list = new List<int>();
      for (int i = start; i <= right; i++)
      {
        list.Add(arr[i]);
      }
      Console.WriteLine(String.Join(",", list));
      result.Add(list);

    }
  }
}
