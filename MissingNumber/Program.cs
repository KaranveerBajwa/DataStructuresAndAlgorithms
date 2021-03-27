using System;

namespace MissingNumber
{
  /*
   * Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.
  Follow up: Could you implement a solution using only O(1) extra space complexity and O(n) runtime complexity?

Example 1:
Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

Example 2:
Input: nums = [0,1]
Output: 2
Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.
Example 3:
Input: nums = [9,6,4,2,3,5,7,0,1]
Output: 8
Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.

Example 4:
Input: nums = [0]
Output: 1
Explanation: n = 1 since there is 1 number, so all numbers are in the range [0,1]. 1 is the missing number in the range since it does not appear in nums.
 


   */
//Todo: use XOR to calculate
//Todo: use diff approach to calculate diff += nums[i] -1;

  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
      Console.WriteLine(MissingNumber(nums));

      Console.WriteLine(MissingNumber(new int[] { 3, 0, 1 }));
      Console.WriteLine(MissingNumber(new int[] { 0 }));
      Console.WriteLine(MissingNumber(new int[] { 0, 1 }));
    }

    static int MissingNumber(int[] nums)
    {
      if (nums == null || nums.Length == 0)
        throw new ArgumentNullException("Array of numbers cannot be null");
      int n = nums.Length   ; // because we have 0 in the array of nums so we have n natural numbers equal to size of array
      int totalSum =  (n * (n + 1) )/ 2;
      int sum = 0;

      for (int i = 0; i < nums.Length; i++)
      {
        sum += nums[i];
      }

      return totalSum - sum;
    }
  }
}
