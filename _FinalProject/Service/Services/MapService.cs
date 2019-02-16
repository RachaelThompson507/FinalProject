using _FinalProject.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface IMapService
    {
        //Create
        Map Create(Map newMap);

        //Read
        Map GetById(int mapId);
        ICollection<Map> GetUserById(string userId);
        ICollection<Map> GetRobinById(int robinId);

        //Update
        Map Update(Map updatedMap);

        //Delete
        bool DeleteById(int mapId);
    }

    public class MapService : IMapService
    {
        private readonly IMapService _mapService;

        public MapService(IMapService mapService) =>
            _mapService = mapService;

        public Map Create(Map newMap) =>
            _mapService.Create(newMap);

        public bool DeleteById(int mapId) =>
            _mapService.DeleteById(mapId);

        public Map GetById(int mapId) =>
            _mapService.GetById(mapId);

        public ICollection<Map> GetRobinById(int robinId) =>
            _mapService.GetRobinById(robinId);

        public ICollection<Map> GetUserById(string userId) =>
            _mapService.GetUserById(userId);

        public Map Update(Map updatedMap) =>
            _mapService.Update(updatedMap);
    }
}
