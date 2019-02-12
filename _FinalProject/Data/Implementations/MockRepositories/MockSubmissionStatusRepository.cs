using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.MockRepositories
{
    public class MockSubmissionStatusRepository : ISubmissionStatusRepository
    {
        private List<SubmissionStatus> SubmissionStatuses = new List<SubmissionStatus>();
        public SubmissionStatus GetById(int submissionStatusId)
        {
            return SubmissionStatuses.Single(c => c.Id == submissionStatusId);
        }

        public ICollection<SubmissionStatus> GetAll()
        {
            var submit = SubmissionStatuses.Select(c => c.Id).ToList() as ICollection<SubmissionStatus>;
            return submit;
        }
    }
}
