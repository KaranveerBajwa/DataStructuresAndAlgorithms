using System;
using System.Collections.Generic;
using System.Text;

namespace FindNSmallNumbers
{
  public class Heap
  {
    int index;
    int[] arr;
    int heapSize;
    public Heap(int n)
    {
      index = 0;
      arr = new int[n + 1];
      heapSize = n;
    }

    public void Insert(int n)
    {
      if (index == heapSize && n < GetMax())
      {
        Delete();
      }
      if (index < heapSize)
      {
        arr[++index] = n;
        Swim(index);
      }
    }

    public int Delete()
    {
      if (index == 0)
        return Int32.MinValue;
      int max = arr[1];
      Swap(1, index);
      index = index - 1;
      Sink(1);
      return max;
    }

    private void Sink(int k)
    {
      int j = 2 * k;
      while (j <= index)
      {
        if (j < index && arr[j + 1] > arr[j])
          j = j + 1;
        if (arr[k] > arr[j])
          break;

        Swap(j, k);
        k = j;
        j = 2 * j;
      }
    }

    private void Swap(int i, int j)
    {
      int temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }

    private void Swim(int i)
    {
      int j = i / 2;
      while (j >= 1 && arr[j] < arr[i])
      {
        Swap(j, i);
        i = j;
        j = j / 2;
      }
    }

    public IEnumerable<int> GetAll()
    {
      List<int> nElements = new List<int>();
      for (int i = 1; i <= index; i++)
      {
        nElements.Add(arr[i]);
      }
      return nElements;
    }

    public int GetMax()
    {
      return arr[1];
    }
  }

}
