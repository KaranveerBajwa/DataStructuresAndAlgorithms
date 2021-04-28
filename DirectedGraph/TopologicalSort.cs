using System;
using System.Collections.Generic;
using System.Text;

namespace DirectedGraphs
{
  public class TopologicalSort
  {
    bool[] visited;
    Stack<int> result;

    public TopologicalSort(DirectedGraph dg, int n)
    {
      visited = new bool[n];
      result = new Stack<int>();
      for (int i = 0; i < n; i++)
      {
        if (!visited[i])
          DFS(dg, i);
      }
    }

    public void DFS(DirectedGraph dg, int v)
    {
      visited[v] = true;
      foreach (var w in dg.AdjacentElements(v))
      {
        if (!visited[w])
          DFS(dg, w);
      }
      result.Push(v);
    }


  }
}
