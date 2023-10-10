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

        public BusinessLocationService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateBusinessLocation(string businessAddress, string businessName, ObjectId client)
        {
            var businessRepository = 
                new Repository<BusinessLocation>(_dbContext.database, "BusinessLocations");
            var newBusiness = new BusinessLocation()
            {
                address = businessAddress,
                name = businessName,
                clientId = client
            };
            businessRepository.Create(newBusiness);
        }

        public void AddBuilding(string buildingName, BusinessLocation location)
        {
            var businessRepository = 
                new Repository<BusinessLocation>(_dbContext.database, "BusinessLocations");
            var newBuilding = new BusinessLocation.Building()
            {
                name = buildingName
            };
            
            location.buildings.Add(newBuilding);
            businessRepository.Update(location);
        }
    }
}
