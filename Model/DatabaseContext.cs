﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MEMS.Model;
using MongoDB.Driver;

namespace MEMS
{
    public class DatabaseContext
    {
        public IMongoDatabase database;
        private static DatabaseContext instance;
      

        private DatabaseContext() 
        {
            
            var connectionString = Environment.GetEnvironmentVariable("MONGO_DB_URI", EnvironmentVariableTarget.User);
                //const string connectionString = "mongodb+srv://seancollins362:3RfZG5Fs4qPg863n@cluster0.1j1jtdz.mongodb.net/";
            if (string.IsNullOrEmpty(connectionString) )
            {
                throw new ArgumentException("Missing database connection string. Did you save the connection string to your environment variable?");
            }
            var client = new MongoClient(connectionString);
            database = client.GetDatabase("MEMSDB1");
        }

        public static DatabaseContext GetInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseContext();
            }

            return instance;
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

        public IMongoCollection<ChangelogEntry> ChangelogEntries
            => database.GetCollection < ChangelogEntry >( "ChangelogEntries");

        public IMongoCollection<MaintenanceSchedule> MaintenanceSchedules
            => database.GetCollection<MaintenanceSchedule>("MaintenanceSchedules");

        public IMongoCollection<MaintenanceEntry> MaintenanceEntries
            => database.GetCollection<MaintenanceEntry>("MaintenanceEntries");
    }
}
