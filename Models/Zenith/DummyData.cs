using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithWebSite.Data;

namespace ZenithWebSite.Models.Zenith
{
    public class DummyData
    {
        public static void Initialize(ApplicationDbContext db)
        {
            // Insert data in Activity table
            if (!db.Activities.Any())
            {
                db.Activities.Add(new Activity
                {
                    ActivityId = 1,
                    ActivityCode = "GPBBQL",
                    ActivityDescription = "BBQ Lunch",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 2,
                    ActivityCode = "GPBINGO",
                    ActivityDescription = "Bingo Tournament",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 3,
                    ActivityCode = "GPGSALE",
                    ActivityDescription = "Garage Sale",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 4,
                    ActivityCode = "GPLGAM",
                    ActivityDescription = "Leadership General Assembly Meeting",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 5,
                    ActivityCode = "GPLUNCH",
                    ActivityDescription = "Lunch",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });

                db.Activities.Add(new Activity
                {
                    ActivityId = 6,
                    ActivityCode = "GPPANCAKEBK",
                    ActivityDescription = "Pancake Breakfast",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 7,
                    ActivityCode = "SCGOLF",
                    ActivityDescription = "Senior’s Golf Tournament",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 8,
                    ActivityCode = "APSWIM",
                    ActivityDescription = "Swimming Exercise for parents",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 9,
                    ActivityCode = "YPSWIM",
                    ActivityDescription = "Swimming Lessons for the youth",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 10,
                    ActivityCode = "YLCOOK",
                    ActivityDescription = "Young ladies cooking lessons",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 11,
                    ActivityCode = "YPBOWL",
                    ActivityDescription = "Youth Bowling Tournament",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 12,
                    ActivityCode = "YPCHOIR",
                    ActivityDescription = "Youth choir practice",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.Activities.Add(new Activity
                {
                    ActivityId = 13,
                    ActivityCode = "YPCRAFT",
                    ActivityDescription = "Youth craft lessons",
                    CreationDate = Convert.ToDateTime("2017-03-23 20:00")
                });
                db.SaveChanges();
            }

            // Insert data in Event table
            if (!db.Events.Any())
            {
                // Monday Feb 13, 2017 to Sunday Feb 19, 2017.
                db.Events.Add(new Event
                {
                    EventId = 1,
                    EventFromDatetime = Convert.ToDateTime("2017-02-14 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-14 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 2,
                    EventFromDatetime = Convert.ToDateTime("2017-02-15 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-15 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 3,
                    EventFromDatetime = Convert.ToDateTime("2017-02-17 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-17 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 4,
                    EventFromDatetime = Convert.ToDateTime("2017-02-17 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-17 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 5,
                    EventFromDatetime = Convert.ToDateTime("2017-02-18 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-18 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 6,
                    EventFromDatetime = Convert.ToDateTime("2017-02-18 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-18 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 7,
                    EventFromDatetime = Convert.ToDateTime("2017-02-18 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-18 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 8,
                    EventFromDatetime = Convert.ToDateTime("2017-02-19 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-19 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 9,
                    EventFromDatetime = Convert.ToDateTime("2017-02-19 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-19 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 10,
                    EventFromDatetime = Convert.ToDateTime("2017-02-19 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-19 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 11,
                    EventFromDatetime = Convert.ToDateTime("2017-02-19 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-19 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 12,
                    EventFromDatetime = Convert.ToDateTime("2017-02-19 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-19 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 13,
                    EventFromDatetime = Convert.ToDateTime("2017-02-19 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-19 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });

                // Monday Feb 20, 2017 to Sunday Feb 26, 2017.
                db.Events.Add(new Event
                {
                    EventId = 14,
                    EventFromDatetime = Convert.ToDateTime("2017-02-21 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-21 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 15,
                    EventFromDatetime = Convert.ToDateTime("2017-02-22 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-22 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 16,
                    EventFromDatetime = Convert.ToDateTime("2017-02-24 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-24 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 17,
                    EventFromDatetime = Convert.ToDateTime("2017-02-24 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-24 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 18,
                    EventFromDatetime = Convert.ToDateTime("2017-02-25 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-25 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 19,
                    EventFromDatetime = Convert.ToDateTime("2017-02-25 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-25 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 20,
                    EventFromDatetime = Convert.ToDateTime("2017-02-25 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-25 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 21,
                    EventFromDatetime = Convert.ToDateTime("2017-02-26 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-26 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 22,
                    EventFromDatetime = Convert.ToDateTime("2017-02-26 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-26 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 23,
                    EventFromDatetime = Convert.ToDateTime("2017-02-26 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-26 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 24,
                    EventFromDatetime = Convert.ToDateTime("2017-02-26 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-26 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 25,
                    EventFromDatetime = Convert.ToDateTime("2017-02-26 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-26 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 26,
                    EventFromDatetime = Convert.ToDateTime("2017-02-26 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-02-26 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });

                // Monday Feb 27, 2017 to Sunday Mar 5, 2017.
                db.Events.Add(new Event
                {
                    EventId = 27,
                    EventFromDatetime = Convert.ToDateTime("2017-02-28 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-02-28 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 28,
                    EventFromDatetime = Convert.ToDateTime("2017-03-01 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-01 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 29,
                    EventFromDatetime = Convert.ToDateTime("2017-03-03 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-03 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 30,
                    EventFromDatetime = Convert.ToDateTime("2017-03-03 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-03 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 31,
                    EventFromDatetime = Convert.ToDateTime("2017-03-04 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-04 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 32,
                    EventFromDatetime = Convert.ToDateTime("2017-03-04 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-04 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 33,
                    EventFromDatetime = Convert.ToDateTime("2017-03-04 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-04 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 34,
                    EventFromDatetime = Convert.ToDateTime("2017-03-05 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-05 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 35,
                    EventFromDatetime = Convert.ToDateTime("2017-03-05 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-05 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 36,
                    EventFromDatetime = Convert.ToDateTime("2017-03-05 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-05 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 37,
                    EventFromDatetime = Convert.ToDateTime("2017-03-05 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-05 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 38,
                    EventFromDatetime = Convert.ToDateTime("2017-03-05 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-05 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 39,
                    EventFromDatetime = Convert.ToDateTime("2017-03-05 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-05 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });

                // Monday Mar 6, 2017 to Sunday Mar 12, 2017.
                db.Events.Add(new Event
                {
                    EventId = 40,
                    EventFromDatetime = Convert.ToDateTime("2017-03-07 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-07 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 41,
                    EventFromDatetime = Convert.ToDateTime("2017-03-08 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-08 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 42,
                    EventFromDatetime = Convert.ToDateTime("2017-03-10 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-10 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 43,
                    EventFromDatetime = Convert.ToDateTime("2017-03-10 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-10 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 44,
                    EventFromDatetime = Convert.ToDateTime("2017-03-11 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-11 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 45,
                    EventFromDatetime = Convert.ToDateTime("2017-03-11 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-11 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 46,
                    EventFromDatetime = Convert.ToDateTime("2017-03-11 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-11 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 47,
                    EventFromDatetime = Convert.ToDateTime("2017-03-12 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-12 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 48,
                    EventFromDatetime = Convert.ToDateTime("2017-03-12 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-12 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 49,
                    EventFromDatetime = Convert.ToDateTime("2017-03-12 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-12 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 50,
                    EventFromDatetime = Convert.ToDateTime("2017-03-12 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-12 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 51,
                    EventFromDatetime = Convert.ToDateTime("2017-03-12 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-12 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 52,
                    EventFromDatetime = Convert.ToDateTime("2017-03-12 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-12 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });
                // Monday Mar 13, 2017 to Sunday Mar 19, 2017.
                db.Events.Add(new Event
                {
                    EventId = 53,
                    EventFromDatetime = Convert.ToDateTime("2017-03-14 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-14 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 54,
                    EventFromDatetime = Convert.ToDateTime("2017-03-15 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-15 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 55,
                    EventFromDatetime = Convert.ToDateTime("2017-03-17 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-17 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 56,
                    EventFromDatetime = Convert.ToDateTime("2017-03-17 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-17 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 57,
                    EventFromDatetime = Convert.ToDateTime("2017-03-18 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-18 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 58,
                    EventFromDatetime = Convert.ToDateTime("2017-03-18 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-18 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 59,
                    EventFromDatetime = Convert.ToDateTime("2017-03-18 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-18 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 60,
                    EventFromDatetime = Convert.ToDateTime("2017-03-19 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-19 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 61,
                    EventFromDatetime = Convert.ToDateTime("2017-03-19 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-19 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 62,
                    EventFromDatetime = Convert.ToDateTime("2017-03-19 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-19 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 63,
                    EventFromDatetime = Convert.ToDateTime("2017-03-19 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-19 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 64,
                    EventFromDatetime = Convert.ToDateTime("2017-03-19 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-19 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 65,
                    EventFromDatetime = Convert.ToDateTime("2017-03-19 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-19 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });
                // Monday Mar 20, 2017 to Sunday Mar 26, 2017.
                db.Events.Add(new Event
                {
                    EventId = 66,
                    EventFromDatetime = Convert.ToDateTime("2017-03-21 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-21 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 67,
                    EventFromDatetime = Convert.ToDateTime("2017-03-22 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-22 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 68,
                    EventFromDatetime = Convert.ToDateTime("2017-03-24 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-24 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 69,
                    EventFromDatetime = Convert.ToDateTime("2017-03-24 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-24 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 70,
                    EventFromDatetime = Convert.ToDateTime("2017-03-25 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-25 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 71,
                    EventFromDatetime = Convert.ToDateTime("2017-03-25 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-25 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 72,
                    EventFromDatetime = Convert.ToDateTime("2017-03-25 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-25 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 73,
                    EventFromDatetime = Convert.ToDateTime("2017-03-26 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-26 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 74,
                    EventFromDatetime = Convert.ToDateTime("2017-03-26 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-26 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 75,
                    EventFromDatetime = Convert.ToDateTime("2017-03-26 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-26 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 76,
                    EventFromDatetime = Convert.ToDateTime("2017-03-26 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-26 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 77,
                    EventFromDatetime = Convert.ToDateTime("2017-03-26 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-26 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 78,
                    EventFromDatetime = Convert.ToDateTime("2017-03-26 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-26 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });
                // Monday Mar 27, 2017 to Sunday April 3, 2017.
                db.Events.Add(new Event
                {
                    EventId = 79,
                    EventFromDatetime = Convert.ToDateTime("2017-03-28 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-28 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 80,
                    EventFromDatetime = Convert.ToDateTime("2017-03-29 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-29 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 81,
                    EventFromDatetime = Convert.ToDateTime("2017-03-31 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-03-31 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 82,
                    EventFromDatetime = Convert.ToDateTime("2017-03-31 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-03-31 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 83,
                    EventFromDatetime = Convert.ToDateTime("2017-04-01 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-01 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 84,
                    EventFromDatetime = Convert.ToDateTime("2017-04-01 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-01 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 85,
                    EventFromDatetime = Convert.ToDateTime("2017-04-01 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-01 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 86,
                    EventFromDatetime = Convert.ToDateTime("2017-04-02 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-02 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 87,
                    EventFromDatetime = Convert.ToDateTime("2017-04-02 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-02 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 88,
                    EventFromDatetime = Convert.ToDateTime("2017-04-02 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-02 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 89,
                    EventFromDatetime = Convert.ToDateTime("2017-04-02 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-02 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 90,
                    EventFromDatetime = Convert.ToDateTime("2017-04-02 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-02 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 91,
                    EventFromDatetime = Convert.ToDateTime("2017-04-02 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-02 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });
                
                // Monday April 3, 2017 to Sunday April 9, 2017.
                db.Events.Add(new Event
                {
                    EventId = 92,
                    EventFromDatetime = Convert.ToDateTime("2017-04-04 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-04 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(7).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 93,
                    EventFromDatetime = Convert.ToDateTime("2017-04-05 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-05 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(4).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 94,
                    EventFromDatetime = Convert.ToDateTime("2017-04-07 17:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-07 19:15"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(11).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 95,
                    EventFromDatetime = Convert.ToDateTime("2017-04-07 19:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-07 20:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(10).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 96,
                    EventFromDatetime = Convert.ToDateTime("2017-04-08 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-08 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(13).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 97,
                    EventFromDatetime = Convert.ToDateTime("2017-04-08 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-08 12:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(12).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 98,
                    EventFromDatetime = Convert.ToDateTime("2017-04-08 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-08 13:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(5).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 99,
                    EventFromDatetime = Convert.ToDateTime("2017-04-09 07:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-09 08:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(6).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 100,
                    EventFromDatetime = Convert.ToDateTime("2017-04-09 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-09 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(9).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 101,
                    EventFromDatetime = Convert.ToDateTime("2017-04-09 08:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-09 10:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(8).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 102,
                    EventFromDatetime = Convert.ToDateTime("2017-04-09 10:30"),
                    EventToDatetime = Convert.ToDateTime("2017-04-09 12:30"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(2).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 103,
                    EventFromDatetime = Convert.ToDateTime("2017-04-09 12:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-09 13:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(1).ActivityId
                });
                db.Events.Add(new Event
                {
                    EventId = 104,
                    EventFromDatetime = Convert.ToDateTime("2017-04-09 13:00"),
                    EventToDatetime = Convert.ToDateTime("2017-04-09 18:00"),
                    CreationUsername = "a",
                    CreationDate = Convert.ToDateTime("2017-02-20 20:00"),
                    IsActive = true,
                    ActivityId = db.Activities.Find(3).ActivityId
                });

                db.SaveChanges();
            }
        }
    }
}
