using System;

namespace FindImmediateSmallerThanX
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 1,2,3,4,5};
      Console.WriteLine(ImmediateSmallest(arr, 1)); ;
      Console.WriteLine("Hello World!");
    }

    static int ImmediateSmallest(int[] arr, int num)
    {
      int diff = Int32.MaxValue;
      int res = -1;
      for (int i = 0; i < arr.Length; i++)
      {
        int curDiff = num - arr[i];
        if (curDiff > 0 && curDiff < diff)
        {
          res = arr[i];
          diff = curDiff;
        }
      }
      return res;
    }
  }
}
 