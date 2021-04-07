using System;
using System.Collections.Generic;

namespace FindNSmallNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int numSmallerElements = 4;
      Heap heap = new Heap(numSmallerElements);
      heap.Insert(1);
      heap.Insert(2);
      heap.Insert(7);
      heap.Insert(8);
      heap.Insert(9);
      heap.Insert(0);

      Console.WriteLine(String.Join(",", heap.GetAll())); // does not give sorted list 

      //// to get sorted list in descending we will have to call Delete elemtent for the heap till it is empty
      //for (int i = 0; i < numSmallerElements; i++)
      //{
      //  int top = heap.Delete();
      //  if (top == Int32.MinValue)
      //    break;
      //  Console.Write(top + " , ");
      //}

      // to get sorted list in ascending we will have to call Delete elemtent for the heap till it is empty
      Stack<int> nElements = new Stack<int>();
      for (int i = 0; i < numSmallerElements; i++)
      {
        int top = heap.Delete();
        if (top == Int32.MinValue)
          break;
        nElements.Push(top);
      }

      while (nElements.Count > 0)
        Console.Write(nElements.Pop() + " ");

      Console.WriteLine();

    }
  }
}
