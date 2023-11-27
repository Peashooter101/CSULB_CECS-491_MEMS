﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using MongoDB.Driver;
using PasswordHashing;

namespace MEMS
{
    public class UserRoleService
    {
            private DatabaseContext _dbContext;
            private Repository<UserRole> userRepository;

            public UserRoleService(DatabaseContext dbContext)
            {
                _dbContext = dbContext;
                userRepository =
                    new Repository<UserRole>(_dbContext.database, "UserRoles");
            }

            public void CreateUserRole(string roleTitle, ObjectId client)
            {
                var userRoleRepository = 
                    new Repository<UserRole>(_dbContext.database, "UserRoles");
                var newUserRole = new UserRole()
                {
                    title = roleTitle,
                    clientId = client
                };
                userRoleRepository.Create(newUserRole);
            }

            //public void AddUser(UserRole role, List<ObjectId> locationIds, string username, string email, string password)
            public void AddUser(UserRole role, string username, string email, string password)
            {
                int salt = new Random().Next(int.MinValue, int.MaxValue);
                PasswordHasherInstance phi = PasswordHasherInstance.Create(HashAlgorithm.SHA256, salt);
                string passHash = phi.Hash(password);
                var userRoleRepository = 
                    new Repository<UserRole>(_dbContext.database, "UserRoles");
                var newUser = new UserRole.User()
                {
                    //locationIds = locationIds,
                    username = username,
                    email = email,
                    password = passHash
                };
            
                role.users.Add(newUser);
                userRoleRepository.Update(role);
            }
            
            public UserRole ReadByName(string name)
            {
                var filter = Builders<UserRole>.Filter.Eq(m => m.title, name);
                return userRepository.Find(filter).FirstOrDefault();
            }
    }
}
