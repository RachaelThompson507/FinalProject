using Data.Interfaces;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockEventRepository : IEventRepository
    {
        private List<Event> Events = new List<Event>();

        public Event Create(Event newEvent)
        {
            newEvent.eventId = Events.OrderByDescending(c => c.eventId).Single().eventId + 1;
            return newEvent;
        }

        public bool DeleteById(int eventId)
        {
            var newEvent = GetById(eventId);
            Events.Remove(newEvent);
            return true;
        }

        public Event GetById(int eventId)
        {
            return Events.Find(c => c.Id == eventId);
        }

        public ICollection<Event> GetCalendarById(int calendarId)
        {
            return Events.FindAll(c => c.eventId == calendarId);
        }

        public ICollection<Event> GetRobinById(int robinId)
        {
            return Events.FindAll(c => c.RobinId == robinId);
        }

        public ICollection<Event> GetUserById(string userId)
        {
            return Events.FindAll(c => c.UserId == userId);
        }

        public Event Update(Event updatedEvent)
        {
            DeleteById(updatedEvent.Id);
            Events.Add(updatedEvent);
            return updatedEvent;
        }
    }
}
