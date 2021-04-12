using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
  public class DepthFirstSearch
  {
    int[] edgeTo;
    bool[] visited;
    int V;
    int Source;
    public DepthFirstSearch(Graph g, int source)
    {
      edgeTo = new int[g.VertexCount];
      visited = new bool[g.VertexCount];
      DFS(g, source);
    }

    private void DFS(Graph g, int v)
    {
      visited[v] = true;
      foreach (var w in g.Neighbors(v))
      {
        if (!visited[w])
        {
          DFS(g, w);
          edgeTo[w] = v;
        }  
      }
    }
  }
}
