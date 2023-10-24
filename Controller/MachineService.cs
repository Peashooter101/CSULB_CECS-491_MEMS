using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace MEMS
{
    public class MachineService
    {
        private readonly DatabaseContext _dbContext;
        private Repository<Machine> machineRepository;
        private const int PageSize = 10;

        public MachineService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            machineRepository =
                new Repository<Machine>(_dbContext.database, "Machines");
        }

        public void CreateMachine(string machineName, string machineModel, string serialNum, string manufacturer, string zone)
        {
            
            var newMachine = new Machine()
            {
                name = machineName,
                manufacturer = manufacturer,
                model = machineModel,
                serial = serialNum,
                zone = zone,
                dateCreated = DateTime.Now,
                isActive = true
            };
            this.machineRepository.Create(newMachine);
        }

        public Machine ReadMachine(ObjectId id)
        {
            var filter = Builders<Machine>.Filter.Eq(m => m.Id, id);
            return machineRepository.Find(filter).FirstOrDefault();
        }

        public Machine ReadByName(string name)
        {
            var filter = Builders<Machine>.Filter.Eq(m => m.name, name);
            return machineRepository.Find(filter).FirstOrDefault();
        }

        public List<Machine> ReadAllByName(string name)
                {
                    var filter = Builders<Machine>.Filter.Eq(m => m.name, name);
                    return machineRepository.Find(filter).ToList();
                }
        public List<Machine> GetMachinesByPage(int pageNumber)
        {
            var skipCount = (pageNumber - 1) * PageSize;
            var filter = Builders<Machine>.Filter.Empty;
            return machineRepository.FindPage(filter, skipCount, PageSize)
                .SortBy(m => m.dateCreated)
                .ToList();

        }
        
    }
}