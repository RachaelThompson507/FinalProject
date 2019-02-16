using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IRobinService
    {
        //Create
        Robin Create(Robin newRobin);

        //Read
        Robin GetById(int robinId);

        //Update
        Robin Update(Robin updatedRobin);

        //Delete
        bool DeleteById(int robinId);
    }
    public class RobinService : IRobinService
    {
        private readonly IRobinService _robinService;

        public RobinService(IRobinService robinService) =>
            _robinService = robinService;

        public Robin Create(Robin newRobin) =>
            _robinService.Create(newRobin);

        public bool DeleteById(int robinId) =>
            _robinService.DeleteById(robinId);

        public Robin GetById(int robinId) =>
            _robinService.GetById(robinId);

        public Robin Update(Robin updatedRobin) =>
            _robinService.Update(updatedRobin);
    }
}
