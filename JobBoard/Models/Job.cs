using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Job
  {
    private string _title;
    private string _description;
    private string _startingDate;
    private string _hourlyRate;
    private static List<Job> _instances = new List<Job>{};

    public Job(string title, string description, string startingDate, string hourlyRate)
    {
      _title = title;
      _description = description;
      _startingDate = startingDate;
      _hourlyRate = hourlyRate;
      _instances.Add(this);

    }

    public string GetDescription()
    {
      return _description;
    }
    public string GetTitle()
    {
      return _title;
    }
    public string GetStartingDate()
    {
      return _startingDate;
    }
    public string GetHourlyRate()
    {
      return _hourlyRate;
    }


    public static List<Job> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


  }
}