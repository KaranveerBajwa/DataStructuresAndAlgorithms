using System;
using System.Collections.Generic;
namespace ImplementQueueWithLinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }


  }


  public class Queue
  {
    public int Count;
    LinkedList<int> linkedList;

    public Queue()
    {
      linkedList = new LinkedList<int>();
    }

    public void Enqueue(int n)
    {
      linkedList.AddLast(n);
    }

    public LinkedListNode<int> Dequeue()
    {
      var res = linkedList.Last;
      linkedList.RemoveLast();
      return res;
    }

    public LinkedList<int> GetFront()
    {
      return linkedList.First;
    }

    p


  }
}
