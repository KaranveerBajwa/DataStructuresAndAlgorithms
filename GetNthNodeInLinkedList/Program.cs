using System;
using System.Collections.Generic;

namespace GetNthNodeInLinkedList
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList<int> ll = new LinkedList<int>();
      ll.AddLast(4);
      ll.AddLast(5);
      ll.AddLast(3);
      ll.AddLast(6);
      ll.AddLast(7);
      ll.AddLast(1);

      int i = 5;
      while (i >= 0)
      {
        Console.Write("Enter the n for nth element: ");
        var input = Console.ReadLine();
        int n = -1;
        bool validInput =  Int32.TryParse(input, out n);
        if (validInput)
        {
          var node = ll.First;
          var res = GetNthNode(n, node);
          if (res != null)
          {
            Console.WriteLine($"Nth element is: {res.Value}");
          }
          else
            Console.WriteLine("Nth element does not exist");
        }
        else
        {
          Console.WriteLine("Invalid input");
        }
      }
    }
    static LinkedListNode<int> GetNthNode(int n, LinkedListNode<int> node)
    {
      if (n < 0)
        return null;
      for (int i = 1; i < n; i++)  // as we are already on first node 
      {
        if (node == null)
          break;
        node = node.Next;
      }
      return node;
    }
  }
}
