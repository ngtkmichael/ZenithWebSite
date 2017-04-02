using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZenithWebSite.Data;
using ZenithWebSite.Models;

namespace ZenithWebSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IActionResult Index()
        {
            var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            var nextmonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Saturday + 2);

            var result = (from e in db.Events
                          join a in db.Activities
                          on e.ActivityId equals a.ActivityId
                          where e.EventFromDatetime.Date >= monday.Date &&
                               e.EventFromDatetime < nextmonday.Date &&
                               e.IsActive == true
                          orderby e.EventFromDatetime ascending
                          select new EventsDto
                          {
                              EventStartDateTime = e.EventFromDatetime,
                              EventEndDateTime = e.EventToDatetime,
                              ActivityDesc = a.ActivityDescription
                          });

            ViewBag.Message = "SORRY, NO EVENT FOR CURRENT WEEK!";
            return View(result);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Zenith Society is a family oriented non-for-profit organization founded in 2014 with one simple mission : to hold events during the week that benefit to the local community. Zenith Society has organized more than 200 successful events for different age & gender groups.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Don't hesitate to contact us to participate to our events. We'll do our best to get back to you within 24 hours.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
