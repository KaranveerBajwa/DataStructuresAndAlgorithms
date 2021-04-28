using System;

namespace FindTopKNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(TopK(new int[] { 3, 1, 5, 12, 2, 11 }, 3));

      Console.WriteLine("What a wonderful World!");
    }

    static int[] TopK(int[] nums, int k)
    {
      MinHeap minHeap = new MinHeap(k);
      for (int i = 0; i < nums.Length; i++)
      {
        if (nums[i] > minHeap.Top() && minHeap.Count == k)
          minHeap.Delete();
        minHeap.Insert(nums[i]);
      }

      int[] result = new int[k];
      int j = 0;
      while(minHeap.Count >0)
      { 
        result[j++] = minHeap.Delete();
      }
      return result;
    }
  }

  class MinHeap
  {
    public int Count;
    int[] arr;

    public MinHeap(int k)
    {
      arr = new int[k + 1];
      Count = 0;
    }

    public void Insert(int val)
    {
      arr[++Count] = val;
      Swim(Count);
    }

    public int Delete()
    {
      int top = arr[1];
      Swap(1, Count);
      Count = Count - 1;
      Sink(1);
      return top;
    }

    private void Sink(int v)
    {
      throw new NotImplementedException();
    }

    private void Swap(int v, int index)
    {
      throw new NotImplementedException();
    }

    private void Swim(int index)
    {
      throw new NotImplementedException();
    }

    public int Top()
    {
      return arr[1];
    }
    
  }
}
