using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
  class Program
  {
    static void Main(string[] args)
    {

      int[] arr = { 1, 2, 3, 4, 5, 6 };
      ReverseArray(arr);
      Console.WriteLine(String.Join(",", arr));
      arr =new int[] { 1, 2 };
      ReverseArray(arr);
      Console.WriteLine(String.Join(",", arr));
      arr = new int[] { 1 };
      ReverseArray(arr);
      Console.WriteLine(String.Join(",", arr));
      arr = null;
      ReverseArray(arr);
     // Console.WriteLine(String.Join(",", arr));


      Console.ReadLine();
    }

    static void ReverseArray(int[] arr)
    {
      if (arr == null || arr.Length <= 1)
        return;
      int start = 0;
      int end = arr.Length - 1;
      while (start <= end)
      {
        Swap(arr, start++, end--);
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
