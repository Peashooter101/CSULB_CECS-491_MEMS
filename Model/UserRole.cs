﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MEMS
{
    public class UserRole : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string title { get; set; }
        public List<User> users { get; set; }
        public ObjectId clientId { get; set; } 

        public class User : IEntity
        {
            public ObjectId Id { get; set; } = ObjectId.Empty;
            public List<ObjectId> locationIds { get; set; } = new List<ObjectId>();
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public int salt { get; set; }
        }
    }
}
