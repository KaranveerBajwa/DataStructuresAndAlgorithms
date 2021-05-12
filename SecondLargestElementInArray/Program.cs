using System;

namespace SecondLargestElementInArray
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(GetSecondLargestIndex(new int[] { 20,10,20,8}));
      Console.WriteLine(GetSecondLargestIndex(new int[] { 20, 20, 20, 20 }));
      Console.WriteLine(GetSecondLargestIndex(new int[] {  }));

      Console.WriteLine("What a wonderful World!");
    }
    static int GetSecondLargestIndex(int[] arr)
    {
      if (arr == null || arr.Length == 0)
        return -1;
      int max = 0;
      int secondMax = -1;
      for (int i = 1; i < arr.Length; i++)
      {
        // greater than max
        if (arr[i] > arr[max])
        {
          secondMax = max;
          max = i;
        }
        else if (arr[i] < arr[max]) // greater than second but less than max
        {
          if (secondMax == -1 || arr[i] > arr[secondMax])
            secondMax = i;
        }
      }
      return secondMax;
    }

  }
}
