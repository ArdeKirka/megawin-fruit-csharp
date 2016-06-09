using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    class dps

    {
        public string _id { get; set; }
        [BsonElement("id")]
        public string idd { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string cabinetNum { get; set; }
        public string rackNum { get; set; }
        public string ipAddressPlc { get; set; }
        public string macAddressPlc { get; set; }
        public string label { get; set; }
        public LocalLink local { get; set; }
        public RackLink[] racks { get; set; }
    }

}