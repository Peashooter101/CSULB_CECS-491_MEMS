using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using MEMS.Model;
using MongoDB.Bson;
using MongoDB.Driver;


namespace MEMS
{
    public class MaintenanceReminderService
    {
        private readonly DatabaseContext _dbContext;
        private Repository<MaintenanceEntry> _maintenanceRepository;

        public MaintenanceReminderService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            _maintenanceRepository = new Repository<MaintenanceEntry>(_dbContext.database, "MaintenanceEntries");
        }

        public void CreateMaintenanceReminder(MaintenanceType maintenanceType, Severity severity, string description, ObjectId machine)
        {
            var newMaintenanceReminder = new MaintenanceEntry()
            {
                type = maintenanceType,
                severity = severity,
                description = description,
                maintenanceTime = DateTime.Today,
                machineId = machine
            };
            _maintenanceRepository.Create(newMaintenanceReminder);
            ServiceUtil.changeLogService.CreateChange(DateTime.Now, "Maintenance Add", "maintenance request added");
        }

        public MaintenanceEntry ReadByType(MaintenanceType type)
        {
            var typeFilter = Builders<MaintenanceEntry>.Filter.Eq(entry => entry.type, type);
            return _maintenanceRepository.Find(typeFilter).FirstOrDefault();
        }

        public List<MaintenanceEntry> ReadAllByType(MaintenanceType type)
        {
            var typeFilter = Builders<MaintenanceEntry>.Filter.Eq(entry => entry.type, type);
            return _maintenanceRepository.Find(typeFilter).ToList();
        }

        public MaintenanceEntry ReadBySeverity(Severity severity)
        {
            var severityType = Builders<MaintenanceEntry>.Filter.Eq(entry =>  entry.severity, severity);
            return _maintenanceRepository.Find(severityType).FirstOrDefault();
        }

        public List<MaintenanceEntry> ReadAllBySeverity(Severity severity)
        {
            var severityType = Builders<MaintenanceEntry>.Filter.Eq(entry => entry.severity, severity);
            return _maintenanceRepository.Find(severityType).ToList();
        }

        public MaintenanceEntry ReadByMachineID(ObjectId machine)
        {
            var filter = Builders<MaintenanceEntry>.Filter.Eq(m => m.machineId, machine);
            return _maintenanceRepository.Find(filter).FirstOrDefault();
        }
    }
}