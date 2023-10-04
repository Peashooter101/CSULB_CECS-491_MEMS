using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MEMS
{
    public class UserRoleService
    {
            private DatabaseContext _dbContext;

            public UserRoleService(DatabaseContext dbContext)
            {
                _dbContext = dbContext;
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

            public void AddUser(UserRole role, List<ObjectId> locationIds, string username, string email, string password)
            {
                var userRoleRepository = 
                    new Repository<UserRole>(_dbContext.database, "UserRoles");
                var newUser = new UserRole.User()
                {
                    locationIds = locationIds,
                    username = username,
                    email = email,
                    password = password
                };
            
                role.users.Add(newUser);
                userRoleRepository.Update(role);
            }
    }
}
