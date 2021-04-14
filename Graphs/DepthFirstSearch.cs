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
      Source = source;
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

    public bool HasPathTo(int v)
    {
      return visited[v];
    }

    public IEnumerable<int> PathTo(int v)
    {
      if (!HasPathTo(v))
        return null;

      Stack<int> path = new Stack<int>();
      int temp = v;
      for (int i = v; edgeTo[i] != Source; i = edgeTo[i])
      {
        path.Push(i);
      }
      path.Push(Source);

      return path;
    }

  }
}
