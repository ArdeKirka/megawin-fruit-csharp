using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class history : MongoBase

    {
        public static history create()
        {
            history hist = new history();
            hist.initUUID();
            hist.type = TYPE_HISTORY;
            return hist;
        }

        private history()
        {
        }

        public DateTime timestamp { get; set; }
        public string value { get; set; }
        public string dataQuality { get; set; }
    }

}