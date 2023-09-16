using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS.Model
{
    internal class ChangelogEntry
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string type { get; set; }
        public ObjectId userId { get; set; } = ObjectId.Empty;
        public string description { get; set; }
    }
}
