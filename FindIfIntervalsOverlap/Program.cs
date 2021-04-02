using System;
using System.Collections.Generic;
using System.Linq;

namespace FindIfIntervalsOverlap
{
  class Program
  {
    static void Main(string[] args)
    {
      Interval[] intervals = new Interval[4];
      intervals[0] = new Interval(1, 2);
      intervals[1] = new Interval(3, 5);
      intervals[2] = new Interval(4, 6);
      intervals[3] = new Interval(6, 8);

      List<Point> listOfPoints = new List<Point>();
      foreach (var interval in intervals)
      {
        listOfPoints.Add(new Point(interval.Start, true));
        listOfPoints.Add(new Point(interval.End, false));
      }

      List<Point> list = listOfPoints.OrderBy(x => x.Time).ToList();
      
      Console.WriteLine(DoesIntervalOverlap(list));
      List<Interval> results = GetMergedIntervals(list);
      Console.WriteLine("Hello World!");
    }

    public static bool DoesIntervalOverlap(List<Point> listOfPoints)
    {
      int count = 0;
      for (int i = 0; i < listOfPoints.Count; i++)
      {
        if (listOfPoints[i].IsStartTime)
        {
          count++;
          if (count > 1)
            return true;
        }
        else
        {
          count--;
        }
      }
      return false;
    }

    static List<Interval> GetMergedIntervals(List<Point> points)
    {
      int start = 0;
      int count = 0;
      List<Interval> list = new List<Interval>();
      for (int i = 0; i < points.Count; i++)
      {
        if (points[i].IsStartTime)
        {
          if (count == 0)
            start = points[i].Time;
          count++;
        }
        else
        {
          count--;
          if (count == 0)
            list.Add(new Interval(start, points[i].Time));
        }
      }

      return list;
    }

  }

  class Interval {
    public int Start;
    public int End;

    public Interval(int start, int end)
    {
      Start = start;
      End = end;
    }
  }

  class Point {
    public int Time;
    public bool IsStartTime;

    public Point(int start, bool isStartTime)
    {
      Time = start;
      IsStartTime = isStartTime;
    }
  }

}
