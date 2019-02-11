using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockCalendarRepository : ICalendarRepository
    {
        private List<Calendar> Calendars = new List<Calendar>();
        public Calendar Create(Calendar newCalendar)
        {
            newCalendar.Id = Calendars.OrderByDescending(c => c.Id).Single().Id + 1;
            return newCalendar;
        }

        public bool DeleteById(int calendarId)
        {
            var calendar = GetById(calendarId);
            Calendars.Remove(calendar);
            return true;
        }

        public Calendar GetById(int calendarId)
        {
            return Calendars.Single(c => c.Id == calendarId);
        }

        public ICollection<Calendar> GetRobinById(int robinId)
        {
            return Calendars.FindAll(c => c.RobinId == robinId);
        }

        public ICollection<Calendar> GetUserById(string userId)
        {
            return Calendars.FindAll(c => c.UserId == userId);
        }

        public Calendar Update(Calendar updatedCalendar)
        {
            DeleteById(updatedCalendar.Id);
            Calendars.Add(updatedCalendar);
            return updatedCalendar;
        }
    }
}
