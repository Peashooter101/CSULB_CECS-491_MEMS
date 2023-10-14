using System;
using MongoDB.Driver;
using PasswordHashing;

namespace MEMS
{
    public class LoginService
    {
        private readonly Repository<UserRole.User> _repository;

        public LoginService()
        {
            MongoClient client = Program.client;
            _repository = new Repository<UserRole.User>(client.GetDatabase(Program.memsDbName), "users");
        }

        public UserRole.User LoginUser(string user, string pass)
        {
            UserRole.User userObj = _repository.FindOne(u => u.username == user);
            if (userObj == null) return default;
            PasswordHasherInstance phi = PasswordHasherInstance.Create(HashAlgorithm.SHA256, userObj.salt);
            return phi.Validate(pass, userObj.password) ? userObj : default;
        }

        public bool CreateUser(string user, string pass)
        {
            UserRole.User userObj = _repository.FindOne(u => u.username == user);
            
            if (userObj != null) return false;
            
            int salt = new Random().Next(int.MinValue, int.MaxValue);
            PasswordHasherInstance phi = PasswordHasherInstance.Create(HashAlgorithm.SHA256, salt);
            string passHash = phi.Hash(pass);
            
            _repository.Create(new UserRole.User
            {
                username = user,
                password = passHash,
                salt = salt
            });
            // TODO: Validate the user was actually created and uploaded to the database, return false if failure maybe?
            return true;
        }

        public bool ChangePassword(UserRole.User user, string oldPass, string newPass)
        {
            PasswordHasherInstance phi = PasswordHasherInstance.Create(HashAlgorithm.SHA256, user.salt);
            if (!phi.Validate(oldPass, user.password)) return false;
            
            int salt = new Random().Next(int.MinValue, int.MaxValue);
            phi = PasswordHasherInstance.Create(HashAlgorithm.SHA256, salt);
            user.password = phi.Hash(newPass);
            user.salt = salt;
            _repository.Update(user);
            return true;
        }
    }
}