using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace MEMS
{
    public class DatabaseContext
    {
        public IMongoDatabase database;

        public DatabaseContext() 
        {
            //var connectionString = Environment.GetEnvironmentVariable("MEMS_CONNECTION_STRING");
            var connectionString = "mongodb+srv://seancollins362:3RfZG5Fs4qPg863n@cluster0.1j1jtdz.mongodb.net/";
            if (string.IsNullOrEmpty(connectionString) )
            {
                throw new ArgumentException("Missing database connection string");
            }
            var client = new MongoClient(connectionString);
            database = client.GetDatabase("MEMSDB1");
        }

        public IMongoCollection<BusinessLocation> BusinessLocations 
            => database.GetCollection<BusinessLocation>("BusinessLocations");

        public IMongoCollection<UserRole> UserRoles
            => database.GetCollection<UserRole>("UserRoles");

        public IMongoCollection<Contact> Contacts
            => database.GetCollection<Contact>("Contacts");

        public IMongoCollection<Client> Clients
            => database.GetCollection<Client>("Clients");

        public IMongoCollection<Machine> Machines
            => database.GetCollection<Machine>("Machines");

        public IMongoCollection<>
    }
}
