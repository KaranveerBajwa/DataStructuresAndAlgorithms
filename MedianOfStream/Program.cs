using System;

namespace MedianOfStream
{
  class Program
  {
    static void Main(string[] args)
    {
//      MinHeap minHeap = new MinHeap();
      MaxHeap heap = new MaxHeap();
      heap.Insert(1);
      heap.Insert(2);
      heap.Insert(7);
      heap.Insert(8);
      heap.Insert(9);
      heap.Insert(0);
      Console.WriteLine(heap.Delete());
      Console.WriteLine(heap.Delete());
      Console.WriteLine(heap.Delete());
      Console.WriteLine(heap.Delete());
      Console.WriteLine(heap.Delete());

      Console.WriteLine("Hello World!");
    }
  }
}
