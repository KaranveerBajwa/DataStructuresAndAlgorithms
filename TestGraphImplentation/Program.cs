using System;
using DirectedGraphs;
using Graphs;

namespace TestGraphImplentation
{
  class Program
  {
    static void Main(string[] args)
    {
      Graph g = new Graph(7);
      //g.AddEdge(0, 1);
      //g.AddEdge(0, 2);
      //g.AddEdge(0, 5);
      //g.AddEdge(2, 3);
      //g.AddEdge(3, 5);
      //g.AddEdge(2, 1);
      //g.AddEdge(2, 4);
      //g.AddEdge(3, 4);

      g.AddEdge(0,5);
      g.AddEdge(0,2);
      g.AddEdge(0,2);
      g.AddEdge(3,6);
      g.AddEdge(3,5);
      g.AddEdge(3,4);
      g.AddEdge(5,2);
      g.AddEdge(6,4);
      g.AddEdge(3,2);
      g.AddEdge(1,4);

      //DepthFirstSearch dfs = new DepthFirstSearch(g, 0);
      //var res = dfs.PathTo(5);

      //TopologicalSort ts = new TopologicalSort(g, 7);
      //Console.WriteLine(String.Join(",", ts.GetOrder()));

      DirectedGraph dg = new DirectedGraph(5);
      //dg.AddEdge(3, 2);
      //dg.AddEdge(3, 0);
      //dg.AddEdge(2, 0);
      //dg.AddEdge(2, 1);
      //DirectedGraphs.TopologicalSort ts = new DirectedGraphs.TopologicalSort(dg, 4);

      dg.AddEdge(4, 2);
      dg.AddEdge(4, 3);
      dg.AddEdge(2, 0);
      dg.AddEdge(2, 1);
      dg.AddEdge(3, 1);
      DirectedGraphs.TopologicalSort ts = new DirectedGraphs.TopologicalSort(dg, 5);

      Console.WriteLine("Its a wonderful world");
    }
  }
}
