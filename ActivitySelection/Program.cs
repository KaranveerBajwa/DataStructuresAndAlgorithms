using System;
using System.Collections.Generic;
using System.Linq;

namespace ActivitySelection
{
  class Program
  {
    static void Main(string[] args)
    {
      Activity[] activities = { new Activity(6,10), new Activity(2,3), new Activity(5,8), new Activity(1,4) };
      Array.Sort(activities);
      Console.WriteLine(MaxActivityCount(activities));
      var res1 = GetMaxActivities(activities);
      Activity[] activities1 = { new Activity(1,3), new Activity(2, 4), new Activity(3, 8), new Activity(10,11) };
      Array.Sort(activities1);

      Console.WriteLine(MaxActivityCount(activities1));
      var res2 = GetMaxActivities(activities1);
    }


    static int MaxActivityCount(Activity[] activities)
    {
      // make sure that activities array is not null or empty
      int count = 1;
      Activity activity = activities[0];
      for (int i = 1; i < activities.Length; i++)
      {
        if (activity.End <= activities[i].Start)
        {
          count++;
          activity = activities[i];
        }
      }
      return count;
    }

    static List<Activity> GetMaxActivities(Activity[] activities)
    {
      // sorted array by end time
      // if the start time of the next one is < than endtime of previous ignore
      // else add to the list
      Activity current = activities[0];
      List<Activity> result = new List<Activity>();
      result.Add(current);
      for (int i = 1; i < activities.Length; i++)
      {
        if (current.End <= activities[i].Start)
        {
          result.Add(activities[i]);
          current = activities[i];
        }
      }
      return result;
    }
  }

  public class Activity : IComparable<Activity>
  {
    public int Start { get; private set; }
    public int End { get; private set; }

    public Activity(int start, int end)
    {
      Start = start;
      End = end;
    }

    public int CompareTo(Activity act)
    {
      return this.End.CompareTo(act.End);
    }

  }
}
