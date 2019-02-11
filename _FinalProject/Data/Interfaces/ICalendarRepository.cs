using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
   public interface ICalendarRepository
    {
        //Create
        Calendar Create(Calendar newCalendar);

        //Read
        Calendar GetById(int calendarId);
        ICollection<Calendar> GetUserById(string userId);
        ICollection<Calendar> GetRobinById(int robinId);

        //Update
        Calendar Update(Calendar updatedCalendar);

        //Delete
        bool DeleteById(int calendarId);
    }
}
