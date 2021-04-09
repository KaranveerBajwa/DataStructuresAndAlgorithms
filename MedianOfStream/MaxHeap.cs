using System;
using System.Collections.Generic;
using System.Text;

namespace MedianOfStream
{
  // to store the smaller half of numbers
  // maximum of all will be at top

  class MaxHeap
  {
    List<int> list = new List<int>();
    public int MaxHeapCount { get; private set; }
    public MaxHeap()
    {
      list.Add(Int32.MinValue);
      MaxHeapCount = 0;
    }

    public void Insert(int n)
    {
      MaxHeapCount = MaxHeapCount + 1;
      list.Add(n);
      Swim();
    }

    public int Delete()
    {
      int max = list[1];
      list[1] = list[MaxHeapCount];
      MaxHeapCount = MaxHeapCount - 1;
      Sink();
      return max;
    }

    void Swim()
    {
      // from last index , till it cannot go any further
      int pIndex = MaxHeapCount/2 ;
      int cIndex = MaxHeapCount;
      while (pIndex >= 1 && list[pIndex] < list[cIndex])
      {
        Swap(pIndex, cIndex);
        cIndex = pIndex;
        pIndex = pIndex / 2;
      }

    }

    void Sink()
    {
      int cIndex = 2;
      int pIndex = 1;

      while (cIndex <= MaxHeapCount)
      {
        if (cIndex < MaxHeapCount && list[cIndex] < list[cIndex + 1])
          cIndex = cIndex + 1;

        if (list[pIndex] > list[cIndex])
          break;

        Swap(pIndex, cIndex);
        pIndex = cIndex;
        cIndex = cIndex * 2;
      }
    
    }

    private void Swap(int pIndex, int cIndex)
    {
      int temp = list[pIndex];
      list[pIndex] = list[cIndex];
      list[cIndex] = temp;
    }

  }
}
