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
    [Route("api/Eventsapi")]
    public class EventsapiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsapiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Eventsapi
        [HttpGet]
        public IEnumerable<Event> GetEvents()
        {
            return _context.Events.OrderBy(e => e.EventFromDatetime);
        }
        
        // GET: api/Eventsapi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = await _context.Events.SingleOrDefaultAsync(m => m.EventId == id);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        //// GET: api/CurrentWeekEventssapi
        //[HttpGet]
        //public async Task<IActionResult> GetCurrentWeekEvents()
        //{
        //    var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
        //    var nextmonday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Saturday + 2);

        //    var @event = await _context.Events.Where(e => e.IsActive == true && e.EventFromDatetime >= monday.Date && e.EventToDatetime < nextmonday.Date);

        //    if (@event == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(@event);

        //    //var result = (from e in db.Events
        //    //              join a in db.Activities
        //    //              on e.ActivityId equals a.ActivityId
        //    //              where e.EventFromDatetime.Date >= monday.Date &&
        //    //                   e.EventFromDatetime < nextmonday.Date &&
        //    //                   e.IsActive == true
        //    //              orderby e.EventFromDatetime ascending
        //    //              select new EventsDto
        //    //              {
        //    //                  EventStartDateTime = e.EventFromDatetime,
        //    //                  EventEndDateTime = e.EventToDatetime,
        //    //                  ActivityDesc = a.ActivityDescription
        //    //              });

        //    //return View(await _context.Activities.OrderBy(i => i.ActivityCode).ToListAsync());


        //    // return _context.Events;
        //}


        // PUT: api/Eventsapi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvent([FromRoute] int id, [FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != @event.EventId)
            {
                return BadRequest();
            }

            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Eventsapi
        [HttpPost]
        public async Task<IActionResult> PostEvent([FromBody] Event @event)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Events.Add(@event);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvent", new { id = @event.EventId }, @event);
        }

        // DELETE: api/Eventsapi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = await _context.Events.SingleOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return Ok(@event);
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }
    }
}