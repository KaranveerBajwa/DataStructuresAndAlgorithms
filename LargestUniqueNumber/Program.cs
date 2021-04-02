using System;
using System.Collections.Generic;

namespace LargestUniqueNumber
{
  /*
   * Given an array of integers A, return the largest integer that only occurs once.
  If no integer occurs once, return -1.
  Example 1:
Input: [5,7,3,9,4,9,8,3,1]
Output: 8
Explanation: 
The maximum integer in the array is 9 but it is repeated. The number 8 occurs only once, so it's the answer.
Example 2:
Input: [9,9,8,8]
Output: -1
Explanation: 
There is no number that occurs only once.
 Note:
  1 <= A.length <= 2000
0 <= A[i] <= 1000
  
   */


  class Program
  {
    static void Main(string[] args)
    {
      int[] nums = { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
      Console.WriteLine(LargestUniqueNumber(nums));
      int[] nums2 = { 9, 9, 8, 8 };
      Console.WriteLine(LargestUniqueNumber(nums2));
      Console.WriteLine("Hello World!");
    }

    static int LargestUniqueNumber(int[] A)
    {
      if (A == null || A.Length == 0)
        return -1;
      Dictionary<int, int> counts = new Dictionary<int, int>();
      for (int i = 0; i < A.Length; i++)
      {
        if (!counts.ContainsKey(A[i]))
          counts.Add(A[i], 0);
        counts[A[i]]++;
      }

      int max = -1;
      foreach (var entry in counts)
      {
        if (entry.Value == 1 && entry.Key > max)
          max = entry.Key;
      }
      return max;
    }
  }
}
