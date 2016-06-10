using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class locals : MongoBase
    {
        public static locals create()
        {
            locals loc = new locals();
            loc.initUUID();
            loc.type = TYPE_LOCALS;
            return loc;
        }

        private locals()
        {
        }

        public TagLink[] tags { get; set; }
    }
}
