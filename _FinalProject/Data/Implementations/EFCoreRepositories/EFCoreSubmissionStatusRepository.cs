using _FinalProject.Data.Context;
using _FinalProject.Model.Models;
using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Implementations.EFCoreRepositories
{
    public class EFCoreSubmissionStatusRepository : ISubmissionStatusRepository
    {
        public SubmissionStatus GetById(int submissionStatusId)
        {
            using (var db = new FinalProjectDBContext())
            {
                return db.SubmissionStatuses.Single(s => s.Id == submissionStatusId);
            }
        }

        public ICollection<SubmissionStatus> GetAll()
        {
            using (var db = new FinalProjectDBContext())
            {
                var statuses = db.SubmissionStatuses.Select(s => s.Id).ToList() as ICollection<SubmissionStatus>;
                return statuses;
            }
        }
    }
}
