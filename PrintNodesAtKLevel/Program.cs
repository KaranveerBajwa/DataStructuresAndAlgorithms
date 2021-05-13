using BinaryTree;
using System;

namespace PrintNodesAtKLevel
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

      PrintKLevelNodexRecursive(node, 2);
    }


    static void PrintKLevelNodexRecursive(Node root, int k)
    {
      if (root == null)
        return;

      if (k == 0)
      {
        Console.WriteLine(root.Value + " ");
      }
      else
      {
        PrintKLevelNodexRecursive(root.Left, k - 1);
        PrintKLevelNodexRecursive(root.Right, k - 1);
      }
    
    }

  }
}
