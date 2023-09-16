using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEMS.Model
{
    public class Machine
    {

        public string name { get; set; }
        public string model { get; set; }
        public string manufacturer { get; set; }
        public string zone { get; set; }

        public ObjectId contactid { get; set; }
        public MaintenanceSchedule maintenanceSchedule { get; set; }

    }
}
