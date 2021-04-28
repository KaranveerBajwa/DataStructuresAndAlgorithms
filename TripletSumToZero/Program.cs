using System;
using System.Collections.Generic;

namespace TripletSumToZero
{
  /*
   *
Given an array of unsorted numbers, find all unique triplets in it that add up to zero.

Example 1:
Input: [-3, 0, 1, 2, -1, 1, -2]
Output: [-3, 1, 2], [-2, 0, 2], [-2, 1, 1], [-1, 0, 1]
Explanation: There are four unique triplets whose sum is equal to zero.

Example 2:
Input: [-5, 2, -1, -2, 3]
Output: [[-5, 2, 3], [-2, -1, 3]]
Explanation: There are two unique triplets whose sum is equal to zero.
   **/
  class Program
  {
    static void Main(string[] args)
    {
      var res = UniqueTriplets(new int[] { -3, 0, 1, 2, -1, 1, -2 });
      Console.WriteLine(String.Join(",", res));

      Console.WriteLine("Hello World!");
    }

    // sort the array 
    // loop through arr and pass arr[i] as value
    // use two sum array, index starting from start and end to get the triplet
   static List<List<int>> UniqueTriplets(int[] arr)
    {
      Array.Sort(arr);
      //loop
      List<List<int>> list = new List<List<int>>();
      for (int i = 0; i < arr.Length; i++)
      {
        SearchTriplet(arr, -arr[i], i + 1, list);
      }

      return list;
    }

    static void SearchTriplet(int[] arr, int target, int left, List<List<int>> list)
    {
      int right = arr.Length - 1;
      while (left < right)
      {
        int sum = arr[left] + arr[right] ;
        int diff = sum + target;
        if (sum == target)
        {
          List<int> inter = new List<int>();
          inter.Add(-target); inter.Add(arr[left]); inter.Add(arr[right]);
          list.Add(inter);
          left++;
          right--;

          while (left < right && arr[left] == arr[left - 1])  // skip equal values to avoid duplicates in result
            left++;

          while(left < right && arr[right] == arr[right+1]) // skip equal values to avoid duplicates
              right--;

        }
        else if (sum < target)
        {
          left++;
        }
        else
          right--;
      }
    }

  }
}
