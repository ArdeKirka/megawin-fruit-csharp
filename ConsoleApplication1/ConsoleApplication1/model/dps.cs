using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class dps : MongoBase

    {
        public static dps create()
        {
            dps dp = new dps();
            dp.initUUID();
            dp.type = TYPE_DPS;
            return dp;
        }
        private dps() { }
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