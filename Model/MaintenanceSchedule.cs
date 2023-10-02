using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MEMS.Model
{
    public class MaintenanceSchedule : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public DateTime nextMaintenance { get; set; }
        public int maintenanceInterval { get; set; }
    }
}
