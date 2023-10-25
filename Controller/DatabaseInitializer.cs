/*using System.Collections.Generic;
using MEMS.Model;
using MongoDB.Driver;

namespace MEMS
{
    public class DatabaseInitializer
    {
        private static DatabaseInitializer _instance;
        private readonly MongoClient _client = Program.client;
        private readonly CreateIndexOptions _uniqueOptions = new CreateIndexOptions { Unique = true };

        private DatabaseInitializer()
        {
            
        }

        public static DatabaseInitializer GetInstance()
        {
            if (_instance == null) _instance = new DatabaseInitializer();
            return _instance;
        }

        public bool CheckDatabase(string databaseName)
        {
            foreach (string s in _client.ListDatabaseNames().ToList())
            {
                if (s == databaseName) return true;
            }
            return false;
        }

        public bool CheckCollection(string databaseName, string collection)
        {
            foreach (string s in _client.GetDatabase(databaseName).ListCollectionNames().ToList())
            {
                if (s == collection) return true;
            }

            return false;
        }

        public void GenerateCollections(string databaseName)
        {
            IMongoDatabase database = _client.GetDatabase(databaseName);
            GenerateBusinessLocationCollection(database);
            GenerateChangelogEntryCollection(database);
            GenerateContactCollection(database);
            GenerateMachineCollection(database);
            GenerateMaintenanceEntryCollection(database);
        }

        private void GenerateBusinessLocationCollection(IMongoDatabase database)
        {
            database.GetCollection<BusinessLocation>("business_locations").Indexes.CreateMany(
                new List<CreateIndexModel<BusinessLocation>>
                {
                    new CreateIndexModel<BusinessLocation>(Builders<BusinessLocation>.IndexKeys
                            .Ascending(b => b.name)
                            .Ascending(b => b.address),
                        _uniqueOptions)
                });
        }

        private void GenerateChangelogEntryCollection(IMongoDatabase database)
        {
            database.GetCollection<ChangelogEntry>("changelog_entries").Indexes.CreateMany(
                new List<CreateIndexModel<ChangelogEntry>>
                {
                    new CreateIndexModel<ChangelogEntry>(Builders<ChangelogEntry>.IndexKeys
                            .Ascending(c => c.userId))
                    // TODO: Create an index for machineId. (Jared)
                    // TODO: Create an index for author. (Jared)
                });
        }

        private void GenerateClientCollection(IMongoDatabase database)
        {
            database.GetCollection<Client>("clients").Indexes.CreateMany(new List<CreateIndexModel<Client>>
            {
                new CreateIndexModel<Client>(Builders<Client>.IndexKeys
                        .Ascending(c => c.name))
            });
        }

        private void GenerateContactCollection(IMongoDatabase database)
        {
            database.GetCollection<Contact>("contacts").Indexes.CreateMany(new List<CreateIndexModel<Contact>>
            {
                new CreateIndexModel<Contact>(Builders<Contact>.IndexKeys
                    .Ascending(c => c.name)
                    .Ascending(c => c.email),
                    _uniqueOptions)
            });
        }

        private void GenerateMachineCollection(IMongoDatabase database)
        {
            database.GetCollection<Machine>("machines").Indexes.CreateMany(new List<CreateIndexModel<Machine>>
            {
                new CreateIndexModel<Machine>(Builders<Machine>.IndexKeys
                    .Ascending(m => m.serial),
                    _uniqueOptions)
            });
        }

        private void GenerateMaintenanceEntryCollection(IMongoDatabase database)
        {
            database.GetCollection<MaintenanceEntry>("maintenance_entries").Indexes.CreateMany(
                new List<CreateIndexModel<MaintenanceEntry>>
                {
                    new CreateIndexModel<MaintenanceEntry>(Builders<MaintenanceEntry>.IndexKeys
                        // TODO: Reconsider how to uniquely identify these.
                        .Ascending(e => e.machineId)
                        .Ascending(e => e.maintenanceTime)
                        .Ascending(e => e.type)
                        .Ascending(e => e.severity),
                        _uniqueOptions
                        )
                });
        }
    }
}*/