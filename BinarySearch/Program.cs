using System;

namespace BinarySearch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(Search(new int[] { 10, 20, 30, 40, 50, 60 }, 10));
      Console.WriteLine(SearchRecursive(new int[] { 10, 20, 30, 40, 50, 60 }, 10));
      Console.WriteLine(Search(new int[] { 10}, 10));
      Console.WriteLine(SearchRecursive(new int[] { 15 }, 10));
      Console.WriteLine(Search(new int[] { 15 }, 10));
      Console.WriteLine(SearchRecursive(new int[] { 10 }, 10));
      Console.WriteLine("Hello World!");
    }
    /*
 * > right = mid -1
 * < left = mid + 1
 * ==  return
 * 
 * return -1
 * */


    static int Search(int[] nums, int target)
    {
      int left = 0;
      int right = nums.Length - 1;
      while (left <= right)
      {
        int mid = left + (right - left) / 2;
        if (nums[mid] > target)
        {
          right = mid - 1;
        }
        else if (nums[mid] < target)
        {
          left = mid + 1;
        }
        else
          return mid;      
      }
      return -1;
    
    }

    static int SearchRecursive(int[] nums, int target)
    { 
      return SearchRecursiveHelper(nums, 0, nums.Length -1, target);    
    }

    static int SearchRecursiveHelper(int[] nums, int left, int right, int target)
    {
      if (left > right)
        return -1;
      int mid = left + (right - left) / 2;
      if (nums[mid] == target)
        return mid;
      else if (nums[mid] < target)
        return  SearchRecursiveHelper(nums, mid + 1, right, target);
      else
        return SearchRecursiveHelper(nums, left, mid - 1, target);
    

    }
  }
}
