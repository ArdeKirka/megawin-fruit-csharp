using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class rpps
    {
        public string _id { get; set; }
        [BsonElement("id")]
        public string idd { get; set; }
        public string type { get; set; }
        public string ipAddressPlc { get; set; }
        public string macAddressPlc { get; set; }
        public string ipAddressHost { get; set; }
        public string macAddressHost { get; set; }
        public string label { get; set; }     
        public LocalLink local { get; set; }
        public DpLink[] dps { get; set; }
    }
}

