using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZenithWebSite.Data;
using ZenithWebSite.Models.Zenith;

namespace ZenithWebSite.Controllers
{
    [Produces("application/json")]
    [Route("api/CurrentWeekEventsapi")]
    public class CurrentWeekEventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CurrentWeekEventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CurrentWeekEvents
        [HttpGet]
        public IEnumerable<Event> GetEvents()
        {
            var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            var nextmonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Saturday + 2);

            return _context.Events
                        .Where(e => e.IsActive == true && e.EventFromDatetime >= monday.Date && e.EventToDatetime < nextmonday.Date)
                        .OrderBy(e => e.EventFromDatetime);
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}
