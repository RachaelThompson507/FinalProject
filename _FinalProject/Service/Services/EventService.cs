using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IEventService
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

    public class EventService : IEventService
    {
        private readonly IEventService _eventService;

        public EventService(IEventService eventService) =>
            _eventService = eventService;

        public Event Create(Event newEvent) =>
            _eventService.Create(newEvent);


        public bool DeleteById(int eventId) =>
            _eventService.DeleteById(eventId);

        public Event GetById(int eventId) =>
            _eventService.GetById(eventId);

        public ICollection<Event> GetCalendarById(int calendarId) =>
            _eventService.GetCalendarById(calendarId);

        public ICollection<Event> GetRobinById(int robinId) =>
            _eventService.GetRobinById(robinId);


        public ICollection<Event> GetUserById(string userId) =>
            _eventService.GetUserById(userId);

        public Event Update(Event updatedEvent) =>
            _eventService.Update(updatedEvent);
    }

}
