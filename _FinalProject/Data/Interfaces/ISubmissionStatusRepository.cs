using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Interfaces
{
    public interface ISubmissionStatusRepository
    {

        //Read
        SubmissionStatus GetById(int submissionStatusId);
        ICollection<User> GetUserById(string userId);


    }
}
