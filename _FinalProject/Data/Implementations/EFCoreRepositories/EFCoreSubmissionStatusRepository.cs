using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreSubmissionStatusRepository : ISubmissionStatusRepository
    {
        public SubmissionStatus GetById(int submissionStatusId)
        {
            throw new NotImplementedException();
        }

        public ICollection<SubmissionStatus> GetUserById(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
