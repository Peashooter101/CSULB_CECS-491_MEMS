using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Xml.Schema;

namespace MEMS.Model
{
    public enum MaintenanceType
    {
        Repair,
        Replace,
        RoutineService,
        Lockout,
        Discontinue
    }
    public enum Severity
    {
        Urgent,
        Moderate,
        Minor
    }
    public class MaintenanceEntry : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public ObjectId machineId { get; set; } = ObjectId.Empty;
        public ObjectId userId { get; set; } = ObjectId.Empty;

        public MaintenanceType type { get; set; }
        public Severity severity { get; set; }
        public string description { get; set; }
        public DateTime maintenanceTime { get; set; }

    }
}
