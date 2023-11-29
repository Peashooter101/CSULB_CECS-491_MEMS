using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS
{
    public class Contact : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string employer { get; set; }
        public ObjectId businessLocation { get; set; } = ObjectId.Empty;
        public BsonObjectId machineRefId { get; set; } = BsonObjectId.Empty;
    }
}
