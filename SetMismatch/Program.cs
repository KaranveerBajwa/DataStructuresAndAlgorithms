using System;
using System.Collections;
using System.Diagnostics;

namespace SetMismatch
{
  /*
   * You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.
You are given an integer array nums representing the data status of this set after the error.
Find the number that occurs twice and the number that is missing and return them in the form of an array.

Example 1:
Input: nums = [1,2,2,4]
Output: [2,3]

Example 2:
Input: nums = [1,1]
Output: [1,2]
   */
  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 1, 2, 2, 4 };
      var errNums = FindErrorNumbers(nums);
      Console.WriteLine(string.Join(",", errNums));

      errNums = FindErrorNumbers(new int[] { 1, 1});
      Console.WriteLine(string.Join(",", errNums));


      errNums = FindErrorNumbers(new int[] {  });
      Console.WriteLine(string.Join(",", errNums));
    }

    static int[] FindErrorNumbers(int[] nums)
    {
      int[] errNums = new int[2];

      if (nums == null || nums.Length == 0)
        throw new ArgumentException("Invalid input");

      bool[] trackNums = new bool[nums.Length + 1];

      for (int i = 0; i < nums.Length; i++)
      {
        if (trackNums[nums[i]])
          errNums[0] = nums[i];
        else
          trackNums[nums[i]] = true;
      }

      for (int i = 1; i < trackNums.Length; i++)
      {
        if (!trackNums[i])
        {
          errNums[1] = i;
          break;
        }
      }

      return errNums;
    }
 
  }
}
