using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface ISubmissionStatusService
    {
        //Read
        SubmissionStatus GetById(int submissionStatusId);
        ICollection<SubmissionStatus> GetAll();
    }

    public class SubmissionStatusService : ISubmissionStatusService
    {
        private readonly ISubmissionStatusService _submissionStatusService;

        public SubmissionStatusService(ISubmissionStatusService submissionStatusService) =>
            _submissionStatusService = submissionStatusService;

        public ICollection<SubmissionStatus> GetAll() =>
            _submissionStatusService.GetAll();
        public SubmissionStatus GetById(int submissionStatusId) =>
            _submissionStatusService.GetById(submissionStatusId);
    }
}
