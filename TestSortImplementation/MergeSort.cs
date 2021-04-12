using System;
using System.Collections.Generic;
using System.Text;

namespace TestSortImplementation
{
  public static class MergeSort
  {

    public static void Merge(int[] arr, int[] aux, int lo, int mid, int hi, Dictionary<int,int> dict)
    {
      int i = lo;
      int j = mid + 1;
      // copy the range to auxillary array
      for (int k = lo; k <= hi; k++)
        aux[k] = arr[k];

      for (int k = lo; k <= hi; k++)
      {
        if (i > mid)
          arr[k] = aux[j++];
        else if (j > hi)
          arr[k] = aux[k++];
        else if (aux[i] > aux[j])
        {

          arr[k] = aux[j++];
        }
        else
        {
          arr[k] = aux[i++];

        }
      }
    }
  }
}
