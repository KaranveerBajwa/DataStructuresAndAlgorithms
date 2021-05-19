using System;

namespace LeftRotateArray
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 1, 2, 3, 4, 5, 6 };
      LeftRotate(arr, 2);
      Console.WriteLine("What a wonderful World!");
    }


    static void LeftRotate(int[] arr, int d)
    {
      Reverse(arr, 0, arr.Length - 1);
      Reverse(arr, 0, arr.Length - 1 - d);
      Reverse(arr, arr.Length -d, arr.Length -1);
    }

    static void Reverse(int[] arr, int start, int end)
    {
      while (start < end)
      {
        Swap(arr, start, end);
        start++;
        end--;
      }    
    }

    static void Swap(int[] arr, int start, int end)
    {
      int temp = arr[start];
      arr[start] = arr[end];
      arr[end] = temp;
    }
  }
}
