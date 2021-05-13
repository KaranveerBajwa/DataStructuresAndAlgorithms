using System;
using BinaryTree;

namespace SizeOfTree
{
  class Program
  {
    static void Main(string[] args)
    {
      Node node = new Node(1);
      //node.Left = new Node(2);
      //node.Left.Left = new Node(3);
      //node.Left.Right = new Node(4);
      //node.Left.Right.Right = new Node(9);
      //node.Left.Right.Right.Right = new Node(10);

      //node.Right = new Node(5);
      //node.Right.Right = new Node(6);
      //node.Right.Left = new Node(222);
      Console.WriteLine(Size(node));
      Console.WriteLine("What a wonderful World!");
    }

    static int Size(Node root)
    {
      if (root == null)
        return 0;
      return 1 + Size(root.Left) + Size(root.Right);
    }
  }
}
