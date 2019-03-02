using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreEventRepository : IEventRepository
    {
        public Event Create(Event newEvent)
        {
            using (var db = new FinalProjectDBContext())
            {
                db.Events.Add(newEvent);
                db.SaveChanges();
                return newEvent;
            }
        }

        public bool DeleteById(int eventId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var newEvent = GetById(eventId);
                db.Events.Remove(newEvent);
                db.SaveChanges();
                return true;
            }
        }

        public Event GetById(int eventId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.Events.Single(c => c.Id == eventId);
            }
        }

        public ICollection<Event> GetCalendarById(int calendarId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var eventCalendar = db.Events.Where(c => c.eventId == calendarId).ToList() as ICollection<Event>;
                return eventCalendar;
            }
        }

        public ICollection<Event> GetRobinById(int robinId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var robinEvent = db.Events.Where(c => c.RobinId == robinId).ToList() as ICollection<Event>;
                return robinEvent;
            }
        }

        public ICollection<Event> GetUserById(string userId)
        {
            using (var db = new FinalProjectDBContext())
            {
                var userEvent = db.Events.Where(c => c.UserId == userId).ToList() as ICollection<Event>;
                return userEvent;
            }
        }

        public Event Update(Event updatedEvent)
        {
            using (var db = new FinalProjectDBContext())
            {
                var update = GetById(updatedEvent.eventId);
                db.Entry(update).CurrentValues.SetValues(updatedEvent);
                db.SaveChanges();
                return update;
            }
        }
    }
}
