﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class LocalLink
    {
        [BsonElement("id")]
        public string idd { get; set; }
        public string type
        { get { return MongoBase.TYPE_LOCALS; } private set { } }
    }
}
