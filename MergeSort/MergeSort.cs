using System;

namespace MergeSorting
{
  public class MergeSort
  {

    public int[] Merge(int[] arr1, int[] arr2)
    {
      int[] res = new int[arr1.Length + arr2.Length];
      int j = 0;
      int k = 0;
      for(int i = 0; i < res.Length; i++)
      {
        if (arr1[j] <= arr2[k])
          res[i] = arr1[j++];
        else
          res[i] = arr2[k++];

        if (j >= arr1.Length)
          res[i] = arr2[k++];

        if (k >= arr2.Length)
          res[i] = arr2[j++];
      }
      return res;
    
    }

  }
}
