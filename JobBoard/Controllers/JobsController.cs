using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {

      [HttpGet("/newjob")]
      public ActionResult NewJobs()
      {
        return View();
      }

      [HttpGet("/jobboard")]
      public ActionResult JobBoard()
      {
        List<Job> allJobs = Job.GetAll();
        return View(allJobs);
      }

      [HttpPost("/jobboard/new")]
      public ActionResult CreateJob(string title, string description, string startingDate, string hourlyRate)
      {
          Job newJob = new Job(title, description, startingDate, hourlyRate);
          return RedirectToAction("JobBoard");
      }

    }
}