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
        public ObjectId machineId { get; set; } = ObjectId.Empty;
        public ObjectId userId { get; set; } = ObjectId.Empty;
        public ObjectId authorId { get; set; } = ObjectId.Empty;
        public DateTime timestamp { get; set; } 
        public string type { get; set; }
        public string description { get; set; }
    }
}
