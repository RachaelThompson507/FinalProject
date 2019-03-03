using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;
using _FinalProject.Model.Models;

namespace Data.Interfaces
{
    public interface IEventRepository
    {
        //Create
        Event Create(Event newEvent);

        //Read
        Event GetById(int eventId);
        ICollection<Event> GetUserById(string userId);
        ICollection<Event> GetRobinById(int robinId);
        ICollection<Event> GetCalendarById(int calendarId);

        //Update
        Event Update(Event updatedEvent);

        //Delete
        bool DeleteById(int eventId);
    }
}
