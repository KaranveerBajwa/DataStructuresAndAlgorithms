using System;

namespace QuickSorting
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = {3,8,6,12,10,7 };
      int pivotIndex = Partition(arr);
      Console.WriteLine("What a wonderful World!");
    }

    static int Partition(int[] arr)
    {
      int pivotIndex = arr.Length - 1;
      int right = arr.Length - 1 - 1;
      int left = 0;

      while (left <= right)
      {
        while (left <= right && arr[left] < arr[pivotIndex])
          left++;

        while (right >= left && arr[right] >= arr[pivotIndex])
          right--;

        if (left > right)
          break;
        Swap(arr, left, right);
        left++;
        right--;
      }

      Swap(arr, right + 1, pivotIndex);
      return right + 1;
    }

    static void Swap(int[] arr, int i, int j)
    {
      int temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }
  }
}
