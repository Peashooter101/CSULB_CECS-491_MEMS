﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS.Model
{
    public class ContactList : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string name { get; set; }
        public int phoneNumber { get; set; }
        public ObjectId businessLocation { get; set; }
    }
}
