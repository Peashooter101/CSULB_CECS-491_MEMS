using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MEMS.Model
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase _database;

        public DatabaseContext(IConfigurationSectionHandler configuration) 
        {
            var connectionString = Environment.GetEnvironmentVariable("MEMS_CONNECTION_STRING");
            if (string.IsNullOrEmpty(connectionString) )
            {
                throw new ArgumentException("Missing database connection string");
            }
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase("cluster0");
        }

        public IMongoCollection<BusinessLocation> BusinessLocations 
            => _database.GetCollection<BusinessLocation>("BusinessLocations");

        public IMongoCollection<UserRole> UserRoles
            => _database.GetCollection<UserRole>("UserRoles");

        public IMongoCollection<ContactList> ContactLists
            => _database.GetCollection<ContactList>("ContactLists");

        public IMongoCollection<Client> Clients
            => _database.GetCollection<Client>("Clients");
    }
}
