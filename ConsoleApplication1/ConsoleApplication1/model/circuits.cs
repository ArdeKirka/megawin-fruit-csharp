using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class circuits : MongoBase
    {
        //changed...
        public static circuits create()
        {
            circuits cir = new circuits();
            cir.initUUID();
            cir.type = TYPE_CIRCUITS;
            return cir;
        }

        private circuits()
        {
        }

        public string circuitNum { get; set; }
        public string cabinetNum { get; set; }
        public TagLink[] tags { get; set; }
    }

}