using System;
using System.Collections.Generic;

namespace DirectedGraphs
{
  public class DirectedGraph
  {
    // array of list
    // info on size of array
    // add edge
    // get adjacent nodes
    // VertexCount

    List<int>[] arr;
    public int VertexCount;

    public DirectedGraph(int n)
    {
      arr = new List<int>[n];
      for (int i = 0; i < n; i++)
      {
        arr[i] = new List<int>();
      }
    }

    public void AddEdge(int from, int to)
    {
      arr[from].Add(to);
    }

    public IEnumerable<int> AdjacentElements(int n)
    {
      return arr[n];
    }

  }
}
