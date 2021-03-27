using System;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ShortestSubarrayToBeSortedToSortArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int[] arr = { 1, 2, 4, 6, 3, 7, 5, 6, 8 };
      Pair res = GetRangeToSortSecondTry(arr);
      int[] arr1 = { 1, 2, 4, 5, 3, 5, 6, };
      Pair res1 = GetRangeToSortSecondTry(arr1);
      int[] arr2 = { 1, 3, 5, 2, 6, 4, 7, 8, 9 };
      Pair res2 = GetRangeToSortSecondTry(arr2);
    }

    static Pair GetRangeToSort(int[] arr)
    {
      int start;
      int end;

      for (start = 0; start < arr.Length - 1; start++)
      {
        if (arr[start + 1] < arr[start]) // there is a dip
          break;
      }

      if (start == arr.Length - 1)
        return null;

      for (end = arr.Length - 1; end > 0; end--)
      {
        if (arr[end - 1] > arr[end])
          break;
      }

      // get the minimum and maximum
      int minValue = Int32.MaxValue; int maxValue = Int32.MinValue;
      for (int i = start; i <= end; i++)
      {
        if (arr[i] < minValue)          minValue = arr[i];
        if (arr[i] > maxValue) maxValue = arr[i];
      }
      int k = start -1;
      while (k >= 0) //  1, 2, 4, 6, 3, 7, 5, 6, 8 , : 3  7
      {
        if (arr[k] > minValue)
          start = k;
        k--;
      }
      int j = end + 1;
      while (j <= arr.Length - 1)
      {
        if (arr[j] < maxValue)
        {
          end = j;
        }
        j++;
      }

      return new Pair(start, end);
    }

    static Pair GetRangeToSortSecondTry(int[] arr)
    {
      if (arr == null || arr.Length == 0)
        return null;
      // get the dip
      int start, end;
      for (start = 0; start < arr.Length - 1; start++)
      {
        if (arr[start + 1] < arr[start])
          break;
      }
      if (start == arr.Length - 1) // array is already sorted
        return null;
      // get the bump from left 
      for (end = arr.Length - 1; end > 0; end--)
      {
        if (arr[end - 1] > arr[end])
          break;
      }
      // 1, 2, 4, 6, 3, 7, 5, 6, 8  : 2,5

      int maxValue = Int32.MinValue;
      int minValue = Int32.MaxValue;
      for (int i = start; i <= end; i++)
      {
        if (arr[i] < minValue)
          minValue = arr[i];
        if (arr[i] > maxValue)
          maxValue = arr[i];
      }

      int k = start - 1;
      while (k >= 0)
      {
        if (arr[k] > minValue)
          start = k;
        k--;
      }

      int j = end + 1;
      while (j >= arr.Length - 1)
      {
        if (arr[j] < maxValue)
          end = j;
        j++;
      }
      return new Pair(start, end);
    }

    
  }
  public class Pair {
    public int Start { get; set; }
    public int End { get; set; }
    public Pair(int start, int end)
    {
      Start = start;
      End = end;
    }
  }
}

