using System;
using System.Collections.Generic;
using System.Text;

namespace RearrangeStrings
{
  public class MaxHeap
  {
    Element[] arr;
    public int Count { get; private set; }

    public MaxHeap(int n)
    {
      arr = new Element[n + 1];
      Count = 0;
    }

    public void Insert(Element element)
    {
      arr[++Count] = element;
      Swim(Count);
    }

    public Element Delete()
    {
      var top = arr[1];
      Swap(1, Count);
      Count=Count -1;
      Sink(1);
      return top;
    
    }

    public void Swim(int index)
    {
      int j = index / 2;
      while (j >= 1 && arr[index].Frequency > arr[j].Frequency)
      {
        Swap(j, index);
        index = j;
        j = j / 2;
      }
    }


    public void Sink(int index)
    {
      int j = index * 2;

      while (j <= Count)
      {
        if (j < Count && arr[j].Frequency < arr[j + 1].Frequency)
          j = j + 1;

        if (arr[j].Frequency < arr[index].Frequency)
          break;
        Swap(j, index);
        index = j;
        j = j * 2;
      }
    
    }


    public void Swap(int i, int j)
    {
      Element temp = arr[i];
      arr[i] = arr[j];
      arr[j] = temp;
    }


  }
}
