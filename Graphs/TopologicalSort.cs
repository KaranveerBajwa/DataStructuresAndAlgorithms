using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
  /*
   * for all unvisited nodes
   * Perform the depth first search and when you land at last element in DFS push that in stack
   * return the stack (which is reverse order list :) )
   * 1. Graph has to be DAG( directed acyclic graph)
   * 
   */ 
  public class TopologicalSort
  {
    bool[] visited;
    Stack<int> topologicalOrder;
    public TopologicalSort(Graph g, int n)
    {
      visited = new bool[n];
      topologicalOrder = new Stack<int>();
      for (int i = 0; i < n; i++)
      {
        if(!visited[i])
          DFS(g, i);
      }
    }


    public void DFS(Graph g, int v)
    {
      visited[v] = true;
      foreach (var w in g.Neighbors(v))
      {
        if (!visited[w])
        {
          DFS(g, w);
        }
      }
      topologicalOrder.Push(v);
    }
    public IEnumerable<int> GetOrder()
    {
      return topologicalOrder.ToArray();
    }

  }
}
