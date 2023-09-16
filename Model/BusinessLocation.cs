using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MEMS.Model
{
    public class BusinessLocation : IEntity
    {
        [BsonId]
        public ObjectId Id { get; set; } = ObjectId.Empty;
        public string address { get; set; }
        public List<Building> buildings { get; set; } = new List<Building>();
        public string name { get; set; }
        public ObjectId clientId { get; set; }

        public class Building
        {
            public ObjectId Id { get; set; } = ObjectId.Empty;
            public string name { get; set;}
        }
    }
}
