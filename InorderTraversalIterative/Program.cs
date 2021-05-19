using System;
using BinaryTree;
using System.Collections.Generic;

namespace InorderTraversalIterative
{
  class Program
  {
    static void Main(string[] args)
    {
      Node node = new Node(1);
      node.Left = new Node(2);
      node.Left.Left = new Node(3);
      node.Left.Right = new Node(4);
      node.Left.Right.Right = new Node(9);
      node.Left.Right.Right.Right = new Node(10);

      node.Right = new Node(5);
      node.Right.Right = new Node(6);
      node.Right.Left = new Node(222);
      Console.WriteLine("Inorder Iterative");
      InOrder(node);

      Console.WriteLine("Inorder Recursive");
      InOrderRecursive(node);
      Console.WriteLine("What a wonderful World!");
    }

    static void InOrder(Node root)
    {
      Node cur = root;
      Stack<Node> st = new Stack<Node>();
      while (cur != null || st.Count > 0)
      {
        while (cur != null)
        {
          st.Push(cur);
          cur = cur.Left;
        }
        cur = st.Pop();
        Console.Write(cur.Value + " ");
        cur = cur.Right;
      }
    }

    static void InOrderRecursive(Node root)
    {
      if (root == null)
        return;

      InOrderRecursive(root.Left);
      Console.Write(root.Value + " ");
      InOrderRecursive(root.Right);
    }
  
  }
}
