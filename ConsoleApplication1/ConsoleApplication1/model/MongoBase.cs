using System;
using MongoDB.Bson.Serialization.Attributes;

namespace ConsoleApplication1.model
{
    public class MongoBase
    {
        public const string TYPE_RPPS = "rpps";
        public const string TYPE_DPS = "dps";
        public const string TYPE_CIRCUITS = "circuits";
        public const string TYPE_TAGS = "tags";
        public const string TYPE_HISTORY = "history";
        public const string TYPE_LOCALS = "locals";
        public const string TYPE_RACKS = "racks";

        protected void initUUID()
        {
            _id = idd = Guid.NewGuid().ToString();
        }
        public string _id { get; private set; }

        [BsonElement("id")]
        public string idd { get; private set; }

        public string type { get; protected set; }
    }
}