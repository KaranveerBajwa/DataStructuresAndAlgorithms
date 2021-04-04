using System;
using System.Collections.Generic;

namespace ReturnAllRootToLeafPaths
{
  /*
	 * Given a binary tree, return all root-to-leaf paths.
	 */
  class Program
  {
    static void Main(string[] args)
    {
      TreeNode root = new TreeNode(1);
      root.Left = new TreeNode(7);
      root.Right = new TreeNode(9);
      root.Left.Left = new TreeNode(4);
      root.Left.Right = new TreeNode(5);
      root.Right.Left = new TreeNode(2);
      root.Right.Right = new TreeNode(7);
      List<List<int>> pathsToLeaf1 = GetAllPaths(root);

      TreeNode root1 = new TreeNode(12);
      root1.Left = new TreeNode(7);
      root1.Right = new TreeNode(1);
      root1.Left.Left = new TreeNode(4);
      root1.Right.Left = new TreeNode(10);
      root1.Right.Right = new TreeNode(5);
      List<List<int>> pathsToLeaf2 = GetAllPaths(root1);

      Console.WriteLine("Hello World!");
    }


    static List<List<int>> GetAllPaths(TreeNode node)
    {
      List<List<int>> pathsToLeaf = new List<List<int>>();
      List<int> path = new List<int>();
      GetAllPathsHelper(node, path, pathsToLeaf);

      return pathsToLeaf;
    }

    static void GetAllPathsHelper(TreeNode node, List<int> path, List<List<int>> pathsToLeaf)
    {
      if (node == null)
        return;

      path.Add(node.Value);

      if (node.Left == null && node.Right == null)
        pathsToLeaf.Add(new List<int>(path));

      GetAllPathsHelper(node.Left, path, pathsToLeaf);
      GetAllPathsHelper(node.Right, path, pathsToLeaf);

      path.RemoveAt(path.Count - 1);
    }
  }

  public class TreeNode
  {
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int x)
    {
      Value = x;
    }
  };

}
