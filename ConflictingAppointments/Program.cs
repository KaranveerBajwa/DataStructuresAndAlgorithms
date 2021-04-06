using System;
using System.Collections.Generic;
namespace ConflictingAppointments
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Interval> intervals = new List<Interval> {
        new Interval(1, 2), new Interval(3, 5), new Interval(4, 6), new Interval(6, 8) };
      intervals.Sort();
      var res = CanAttendAppointments(intervals) ? "Yes" : "No";
    Console.WriteLine($"Can he/she attend all appointments: { res}");

      intervals = new List<Interval> {
        new Interval(1, 2), new Interval(3, 4), new Interval(4, 6), new Interval(6, 8) };
      intervals.Sort();
      res = CanAttendAppointments(intervals) ? "Yes" : "No";

      Console.WriteLine($"Can he/she attend all Appointments:{res}");

      Console.WriteLine("Its a wonderful world");
    }

    static bool CanAttendAppointments(List<Interval> intervals)
    {
      for (int i = 0; i < intervals.Count - 1; i++)
      {
        if (intervals[i].End > intervals[i + 1].Start)
          return false;
      }
      return true;
    }

  }


  public class Interval : IComparable<Interval>
  {

    public int Start { get; private set; }
    public int End { get; private set; }
    public Interval(int start, int end)
    {
      Start = start;
      End = end;
    }

    public int CompareTo(Interval interval)
    {
      return this.Start.CompareTo(interval.Start);
    }
  }

}
