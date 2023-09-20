using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS
{
    public class Machine : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string name { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string zone { get; set; }
        public ObjectId contactid { get; set; } = ObjectId.Empty;
        public ObjectId maintenanceScheduleId { get; set; } = ObjectId.Empty;
        public ObjectId buildingId { get; set; } = ObjectId.Empty;



    }
}
