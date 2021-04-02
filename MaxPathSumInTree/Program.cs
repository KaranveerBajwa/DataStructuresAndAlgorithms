using BinaryTree;
using System;
using System.Xml;
using System.Xml.Linq;

namespace MaxPathSumInTree
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

      int maxSum = PathSum(node);
      Console.WriteLine("Hello World!");
    }

    static int PathSum(Node node)
    {
      if (node == null)
        return 0;

      return node.Value + Math.Max(PathSum(node.Left), PathSum(node.Right));
    }
  }
}
