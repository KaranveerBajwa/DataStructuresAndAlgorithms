using MaxHeap;
using System;

namespace TestHeap
{
  class Program
  {
    static void Main(string[] args)
    {
      MaxHeapImpl heap = new MaxHeapImpl(6);
      heap.Insert(5);
      heap.Insert(6);
      heap.Insert(7);
      heap.Insert(8);
      heap.Insert(10);
      heap.Insert(11);
      Console.WriteLine(heap.GetMax());
      Console.WriteLine(heap.Delete());
      Console.WriteLine("Hello World!");
    }
  }
}
