using System;
using Graphs;

namespace TestGraphImplentation
{
  class Program
  {
    static void Main(string[] args)
    {
      Graph g = new Graph(6);
      g.AddEdge(0, 1);
      g.AddEdge(0, 2);
      g.AddEdge(0, 5);
      g.AddEdge(2, 3);
      g.AddEdge(3, 5);
      g.AddEdge(2, 1);
      g.AddEdge(2, 4);
      g.AddEdge(3, 4);

      DepthFirstSearch dfs = new DepthFirstSearch(g, 0);
      var res = dfs.PathTo(5);

      Console.WriteLine("Its a wonderful world");
    }
  }
}
