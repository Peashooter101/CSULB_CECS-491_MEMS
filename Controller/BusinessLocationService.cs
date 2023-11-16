using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS
{
    public class BusinessLocationService
    {
        private DatabaseContext _dbContext;
        private Repository<BusinessLocation> businessLocationDB;

        public BusinessLocationService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            businessLocationDB = new Repository<BusinessLocation>(_dbContext.database, "BusinessLocations");
        }

        public void CreateBusinessLocation(string businessAddress, string businessName, ObjectId client)
        {
            var newBusiness = new BusinessLocation()
            {
                address = businessAddress,
                name = businessName,
                clientId = client
            };
            businessLocationDB.Create(newBusiness);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.CreateBusinessLocation, businessAddress + " created");
        }
        

        public void DeleteBusinessLocation(ObjectId businessLocationId)
        {
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.DeleteBusinessLocation, businessLocationDB.FindOne(loc => loc.Id == businessLocationId).name + " deleted");
            businessLocationDB.Delete(businessLocationId);
        }

        public void ModifyBusinessLocationName(ObjectId businessLocationId, string newName)
        {
            var location = businessLocationDB.FindOne(loc => loc.Id == businessLocationId);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.ModifyBusinessLocationName, location.name + " changed to " + newName);
            location.name = newName;
            businessLocationDB.Update(location);
        }

        public void AddBuilding(string buildingName, BusinessLocation location)
        {
            var newBuilding = new BusinessLocation.Building()
            {
                name = buildingName
            };
            bool newBuildingCheck = true;
            foreach (var loc in businessLocationDB.FindList(loc => true))
            {
                if (loc.buildings.Contains(newBuilding))
                {
                    newBuildingCheck = false;
                }
            }
            if (newBuildingCheck)
            {
                ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.CreateBuilding, newBuilding.name + " created");
            }
            location.buildings.Add(newBuilding);
            businessLocationDB.Update(location);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.AddBuilding, "added " + buildingName + " to " + location);
        }

        public void RemoveBuilding(ObjectId buildingId, ObjectId businessLocationId)
        {
            var location = businessLocationDB.FindOne(loc => loc.Id == businessLocationId);
            var target = new BusinessLocation.Building()
            {
                Id = buildingId
            }; //I don't like how this is written and doubt that it will work
            location.buildings.Remove(target);
            businessLocationDB.Update(location);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.RemoveBuilding, "removed " + target.name + " from " + location.name);
        }

        public void DeleteBuilding(ObjectId buildingId)
        {
            var target = new BusinessLocation.Building()
            {
                Id = buildingId
            };
            foreach (var location in businessLocationDB.FindList(loc => true))
            {
                if (location.buildings.Contains(target))
                {
                    RemoveBuilding(buildingId, location.Id);
                }
            }
            var targetName = target.name;
            businessLocationDB.Delete(buildingId);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.DeleteBuilding, "deleted " + targetName);
        }

        public void ModifyBuildingName(ObjectId buildingId, ObjectId businessLocationId, string newName)
        {
            var location = businessLocationDB.FindOne(loc => loc.Id == businessLocationId);
            var target = new BusinessLocation.Building()
            {
                Id = buildingId
            };
            var oldName = target.name;
            target.name = newName;
            businessLocationDB.Update(location);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, Type.ModifyBuildingName, oldName + " changed to " + newName);
        }
    }
}
