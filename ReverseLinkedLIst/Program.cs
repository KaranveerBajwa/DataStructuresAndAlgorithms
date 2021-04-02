using System;

namespace ReverseLinkedLIst
{
  class Program
  {
    static void Main(string[] args)
    {
      Node head = new Node(0);
      head.Next = new Node(1);
      head.Next.Next = new Node(2);
      head.Next.Next.Next = new Node(3);
      head.Next.Next.Next.Next = new Node(4);
      head.Next.Next.Next.Next.Next = new Node(5);
      head = ReverseLinkedList(head);
      Console.WriteLine("Hello World!");
    }

    static Node ReverseLinkedList(Node head)
    {
      Node curNode = head;
      Node prev = null;
      Node next;

      while (curNode != null)
      {
        next = curNode.Next;
        curNode.Next = prev;
        prev = curNode;
        curNode = next;
      }
      return prev;
    }
  }

  public class Node
  {
    public int Value;
    public Node Next;

    public Node(int val)
    {
      Value = val;
    }
  }
}
