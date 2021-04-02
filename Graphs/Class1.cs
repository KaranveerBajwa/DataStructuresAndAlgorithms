using System;
using System.Collections.Generic;

namespace Graphs
{
  public class Graph
  {
    public readonly int VertexCount;

    List<int>[] adjacencyList;

    public Graph(int v)
    {
      VertexCount = v;
      adjacencyList = new List<int>[v];
      for (int i = 0; i < v; i++)
      {
        adjacencyList[i] = new List<int>();
      }
    }

    public void AddEdge(int v, int w)
    {
      adjacencyList[v].Add(w);
      adjacencyList[w].Add(v);
    }

    public IEnumerable<int> Neighbors(int v)
    {
      return adjacencyList[v];
    }
}
}
