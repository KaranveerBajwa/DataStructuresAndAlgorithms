using System;
using System.Collections.Generic;

namespace TestSortImplementation
{
  class Program
  {
    static int global = 0;
    static void Main(string[] args)
    {
      int[] arr = {3,1,2 };
      int[] aux = new int[arr.Length];
      int[] count = { 0 };
      var res = Sort(arr, aux, 0, arr.Length - 1, count);

      Console.WriteLine(String.Join(",", arr));
    }


    public static int Sort(int[] arr,int[] aux, int lo, int hi)
    {
      int   invCount = 0;
      if (lo >= hi)
        return 0;
      int mid = lo + (hi - lo) / 2;
      invCount += Sort(arr, aux, lo, mid);
      invCount += Sort(arr, aux,mid + 1, hi);
      invCount += Merge(arr, aux, lo, mid, hi);
      return invCount;
    }

    public static int Merge(int[] arr, int[] aux, int lo, int mid, int hi)
    {
      int invCount = 0;
      int i = lo;
      int j = mid + 1 ;
      // copy the range to auxillary array
      for (int k = lo; k <= hi; k++)
        aux[k] = arr[k];

      for (int k = lo; k <= hi; k++)
      {
        if (i > mid  )
          arr[k] = aux[j++];
        else if (j > hi)
          arr[k] = aux[i++];
        else if (aux[i] > aux[j])
        {
          invCount = invCount + (mid + 1  -i);
          arr[k] = aux[j++];
        }
        else
        {
          arr[k] = aux[i++];

        }
      }
      return invCount;
    }


  }
}
