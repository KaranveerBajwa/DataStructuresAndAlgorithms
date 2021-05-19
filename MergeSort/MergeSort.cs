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


    public void Merge(int[] arr, int[] aux, int low, int mid, int high)
    {
      for (int i = low; i <= high; i++)
      {
        aux[i] = arr[i];
      }

      int left = low;
      int right = mid + 1;

      for (int i = low; i <= high; i++)
      {
        if (left > mid)
          arr[i] = aux[right++];
        else if (right > high)
          arr[i] = aux[left++];
        else if (aux[left] <= aux[right])
          arr[i] = aux[left++];
        else
          arr[i] = aux[right++];
      }
    
    }

  }
}
