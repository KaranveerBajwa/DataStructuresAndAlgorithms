using System;
using System.Collections.Generic;

namespace FindMissingNumbers
{
  /*
   * Given an array nums of n integers where nums[i] is in the range [1, n], return an array of all the integers in the range [1, n] that do not appear in nums.
  Example 1:
Input: nums = [4,3,2,7,8,2,3,1]
Output: [5,6]

Example 2:
Input: nums = [1,1]
Output: [2] 
   * 
   */
  class Program
  {
    static void Main(string[] args)
    {
      //int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };
      int[] arr = { 0,0 };
      Console.WriteLine(String.Join(",", FindDisapperedNumberWithoutAdditionalSpace(arr)));
      Console.WriteLine("Hello World!");
    }

    static IEnumerable<int> FindDisapperedNumberWithAdditionalSpace(int[] arr)
    {
      if (arr == null || arr.Length == 0)
        throw new  ArgumentNullException("Invalid input please provide valid input");
      bool[] checkNumbers = new bool[arr.Length + 1];
      List<int> missingInts = new List<int>();
      for (int i = 0; i < arr.Length; i++)
      {
        if (!checkNumbers[arr[i]])
        {
          checkNumbers[arr[i]] = true;
        }
      }

      for (int i = 1; i < checkNumbers.Length; i++)
      {
        if (!checkNumbers[i])
          missingInts.Add(i);
      }

      return missingInts;

    
    }


    static IEnumerable<int> FindDisapperedNumberWithoutAdditionalSpace(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        return null;

      List<int> missingInts = new List<int>();

      for (int i = 0; i < nums.Length; i++)
      {
        int index = Math.Abs(nums[i]) - 1;

        if (nums[index] > 0)
          nums[index] = nums[index] * -1;
      }       

      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] > 0)
          missingInts.Add(i + 1);
      }

      return missingInts;
    }

  }
}
