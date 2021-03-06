﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.model
{
    public class tags : MongoBase
    {
        public static tags create()
        {
            tags tag = new tags();
            tag.initUUID();
            tag.type = TYPE_TAGS;
            return tag;
        }
        private tags() { }
        public string tagPrefix { get; set; }
        public string rackNum { get; set; }
        public string cabinetNum { get; set; }
        public string circuitNum { get; set; }
        public string phase { get; set; }
        public string memLocation { get; set; }
        public string postTagname { get; set; }
        public string tagname { get; set; }
        public string description { get; set; }
        public string units { get; set; }
        public bool isWritable { get; set; }
        public bool isEnabled { get; set; }
        public bool isHistorical { get; set; }
        public int divider { get; set; }
        public int modbusAddress { get; set; }
        public double value { get; set; }
        public DateTime lastUpdate { get; set; }
        public HistoryLink[] history { get; set; }
    }

}

