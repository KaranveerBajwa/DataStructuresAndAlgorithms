using System;

namespace MaxHeap
{
  public class MaxHeapImpl
  {
    int index;
    int[] arr;

    public MaxHeapImpl(int n)
    {
      arr = new int[n+1];
      index = 0;
    }



    public void Insert(int val)
    {
      arr[++index] = val;
      Swim(index);
    }

    public int GetMax()
    {
      return arr[1];
    }
    public int Delete()
    {
      int max = arr[1];
      Swap(1, index);
      index = index - 1;
      Sink(1);
      return max;
    }

    void Swim(int n)
    {
      int j = n / 2;

      while (j >= 1 && arr[j] < arr[n])
      {
        Swap(j, n);
        n = j;
        j = j / 2;
      }
    }

    void Sink(int n)
    { 
      int j = 2 * n;
      while (j <= index)
      {
        if (j < index && arr[j] < arr[j + 1])
          j = j + 1;
        if (arr[n] > arr[j])
          break;
        Swap(j, n);
        n = j;
        j = 2 * n;
      }

    }

    void Swap(int j, int n)
    {
      int temp = arr[j];
      arr[j] = arr[n];
      arr[n] = temp;
    }
  }
}
