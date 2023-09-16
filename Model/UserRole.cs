using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MEMS.Model
{
    public class UserRole
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string title { get; set; }
        public List<User> users { get; set; }
        public ObjectId clientId { get; set; } 

        public class User
        {
            public ObjectId Id { get; set; } = ObjectId.Empty;
            public List<ObjectId> locationIds { get; set; } = new List<ObjectId>();
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}
