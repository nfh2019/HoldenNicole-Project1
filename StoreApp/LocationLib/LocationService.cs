﻿using StoreDB.Models;
using StoreUI;
using System.Collections.Generic;

namespace LocationLib
{
    public class LocationService : ILocationService
    {
        private readonly DBRepo dbRepo;
        public LocationService(DBRepo repo)
        {
            this.dbRepo = repo;
        }

        public LocationModel GetLocationByID(int id)
        {
            LocationModel location = dbRepo.GetLocationByID(id);
            return location;
        }
        public LocationModel GetLocationByName(string name)
        {
            LocationModel location = dbRepo.GetLocationByName(name);
            return location;
        }
        public List<LocationModel> GetAllLocations()
        {
            List<LocationModel> locations = dbRepo.GetAllLocations();
            return locations;
        }
        public List<OrderModel> GetAllOrdersByLocationIDPriceAscending(int id)
        {
            List<OrderModel> getOrdersByLocation = dbRepo.GetAllOrdersByLocationIDPriceAscending(id);
            return getOrdersByLocation;
        }
        public List<OrderModel> GetAllOrdersByLocationIDDateDescending(int id)
        {
            List<OrderModel> getOrdersByLocation = dbRepo.GetAllOrdersByLocationIDDateDescending(id);
            return getOrdersByLocation;
        }
        public List<OrderModel> GetAllOrdersByLocationID(int id)
        {
            List<OrderModel> getOrdersByLocation = dbRepo.GetAllOrdersByLocationID(id);
            return getOrdersByLocation;
        }
        public List<OrderModel> GetAllOrdersByLocationIDPriceDescending(int id)
        {
            List<OrderModel> getOrdersByLocation = dbRepo.GetAllOrdersByLocationIDPriceDescending(id);
            return getOrdersByLocation;
        }

        public ManagerModel GetManagerByName(string managerUserName)
        {
            ManagerModel manager = dbRepo.GetManagerByName(managerUserName);
            return manager;
        }

    }
}
