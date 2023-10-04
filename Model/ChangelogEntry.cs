using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS
{
    public class ChangelogEntry : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string type { get; set; }
        public ObjectId author { get; set; } = ObjectId.Empty;
        public string description { get; set; }
        public DateTime timestamp { get; set; } 
        public ObjectId machine { get; set; } = ObjectId.Empty;
        public ObjectId user { get; set; } = ObjectId.Empty;
    }
}
