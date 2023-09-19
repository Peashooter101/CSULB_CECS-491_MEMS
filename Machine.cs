using System;
using System.Security.Cryptography;

namespace MEMS
{
    public class Machine
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Zone { get; set; }
        public string UniqueId { get; set; }
    }
    
}