using BinaryTree;
using System;

namespace LCAOfBinaryTree
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

      Node n1 = node.Left.Left;
      Node n2 = node.Left.Right;
      Node res = LCA(node, n1, n2);
    }

    static Node LCA(Node current, Node n1, Node n2)
    {
      if (current == null)
        return null;
      Console.WriteLine($"Node LCA(Node {current.Value}, Node {n1.Value}, Node {n2.Value})");
      if (current == n1 || current == n2)
        return current;

      Node left = LCA(current.Left, n1, n2);
      Node right = LCA(current.Right, n1, n2);
      if (left != null && right != null)
        return current;

      return left == null ? right : left;
    }
  }
}
