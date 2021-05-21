using System;

namespace FindEquilibriumPoint
{
  // Give an array of integer find if it has equibrium point
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 3, 4, 8, -9, 20, 6 };
      Console.WriteLine(HaveEquilibrium(arr));

      int[] arr1 = { 4,2,-2};
      Console.WriteLine(HaveEquilibrium(arr1));

      int[] arr2 = { 4, 2, 2 };
      Console.WriteLine(HaveEquilibrium(arr2));

      int[] arr3 = { 0,0,0};
      Console.WriteLine(HaveEquilibrium(arr3));
      Console.WriteLine("What a wonderful World!");
    }

    static bool HaveEquilibrium(int[] arr)
    {
      int sum = 0;
      int lSum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        sum = sum + arr[i];
      }

      for (int i = 0; i < arr.Length; i++)
      {
        if (lSum == sum - arr[i])
          return true;

        lSum = lSum + arr[i];
        sum = sum - arr[i];
      }
      return false;    
    }

  }
}
