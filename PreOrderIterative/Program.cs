using System;
using System.Collections.Generic;
using BinaryTree;

namespace PreOrderIterative
{
  class Program
  {
    static void Main(string[] args)
    {
      //Node node = new Node(1);
      //node.Left = new Node(2);
      //node.Left.Left = new Node(3);
      //node.Left.Right = new Node(4);
      //node.Left.Right.Right = new Node(9);
      //node.Left.Right.Right.Right = new Node(10);

      //node.Right = new Node(5);
      //node.Right.Right = new Node(6);
      //node.Right.Left = new Node(222);
      Node node = new Node(10);
      node.Left = new Node(20);
      node.Right = new Node(30);
      node.Left.Left = new Node(40);
      node.Left.Left.Left = new Node(80);
      node.Left.Left.Right = new Node(90);
      node.Left.Right = new Node(50);
      node.Right.Left = new Node(60);
      node.Right.Right = new Node(70);

      PreOrder(node);
      Console.WriteLine("What a wonderful World!");
    }

    static void PreOrder(Node node)
    {
      if (node == null)
        return;
      Stack<Node> stack = new Stack<Node>();
      stack.Push(node);

      while (stack.Count > 0)
      {
        Node cur = stack.Pop();
        Console.Write(cur.Value + " ");
        if (cur.Right != null)
          stack.Push(cur.Right);
        if (cur.Left != null)
          stack.Push(cur.Left);
      
      }
      Console.WriteLine();
    
    }
  }
}
