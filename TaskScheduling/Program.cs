using System;
using System.Collections.Generic;

namespace TaskScheduling
{
  class Program
  {
    // create a graph  with from and to
    // once complete do the DFS and populate the path

    static void Main(string[] args)
    {
      Console.WriteLine("What wonderful World!");

      int tasks = 6;
      int[,] prereqs = { { 2, 5 }, { 0, 5 }, { 0, 4 }, { 1, 4 }, { 3, 2 }, { 1, 3 } };

      Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
      bool[] visited = new bool[tasks];
      Stack<int> result = new Stack<int>();
      BuildGraph(dict, prereqs, tasks);
      foreach (var entry in dict)
      {
        if (!visited[entry.Key])
          DFS(dict, entry.Key, visited, result);      
      }

    }

    private static void DFS(Dictionary<int, List<int>> dict, int key, bool[] visited, Stack<int> result)
    {
      visited[key] = true;

      foreach (var w in dict[key])
      {
        if (!visited[w])
        {
          DFS(dict, w, visited, result);
        }
      }
      result.Push(key);
    }

    static void BuildGraph(Dictionary<int, List<int>> dict, int[,] prereqs, int tasks)
    {
      int rowCount = prereqs.GetLength(0);
      int colCount = prereqs.GetLength(1);
      for (int i = 0; i < tasks; i++)
      {
          if (!dict.ContainsKey(i))
            dict.Add(i, new List<int>());
      }

      for (int i = 0; i < rowCount; i++)
      {
        dict[prereqs[i, 0]].Add(prereqs[i, 1]);
      }
    }

  }
}



/*
 * There are ‘N’ tasks, labeled from ‘0’ to ‘N-1’. Each task can have some prerequisite tasks which need to be completed before it can be scheduled. Given the number of tasks and a list of prerequisite pairs, find out if it is possible to schedule all the tasks.

Example 1:

Input: Tasks=3, Prerequisites=[0, 1], [1, 2]
Output: true
Explanation: To execute task '1', task '0' needs to finish first. Similarly, task '1' needs to finish 
before '2' can be scheduled. A possible sceduling of tasks is: [0, 1, 2] 
Example 2:

Input: Tasks=3, Prerequisites=[0, 1], [1, 2], [2, 0]
Output: false
Explanation: The tasks have cyclic dependency, therefore they cannot be sceduled.
Example 3:

Input: Tasks=6, Prerequisites=[2, 5], [0, 5], [0, 4], [1, 4], [3, 2], [1, 3]
Output: true
Explanation: A possible sceduling of tasks is: [0 1 4 3 2 5] 
*/
