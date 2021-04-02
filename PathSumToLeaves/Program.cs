using BinaryTree;
using System;
using System.Collections.Generic;
using System.Xml;

namespace PathSumToLeaves
{
  class Program
  {
    static void Main(string[] args)
    {
      Node node = new Node(1);
      node.Left = new Node(2);
      node.Left.Left = new Node(3);
      node.Left.Right = new Node(4);

      node.Right = new Node(5);
      node.Right.Right = new Node(6);

      List<int> pathSums = new List<int>();
      PathSumToLeaves(node, 0, pathSums);

    }

    static void PathSumToLeaves(Node curr, int sum, List<int> pathSums)
    {
      if (curr == null)
      {
        return;
      }

      sum = sum + curr.Value;
      if (curr.Left == null && curr.Right == null)
        pathSums.Add(sum);
      PathSumToLeaves(curr.Left, sum, pathSums);
      PathSumToLeaves(curr.Right, sum, pathSums);
    }
  }
}
