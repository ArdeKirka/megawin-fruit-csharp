using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1.mongo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.model;
using System.Diagnostics;

namespace ConsoleApplication1.mongo.Tests
{
    [TestClass()]
    public class MongoHelperTests
    {
        MongoHelper mongoHelper;
        [TestInitialize]
        public void setUp()
        {
            mongoHelper = new MongoHelper("162.243.36.108", "Apple");
        }

        [TestMethod()]
        public void getRppsTest()
        {
            rpps rpp = mongoHelper.getRpps();
            Assert.IsNotNull(rpp);
            Trace.WriteLine(rpp);
        }

        [TestMethod()]
        public void getTagsNoHistoryTest()
        {
            List<tags> tags = mongoHelper.getTagsNoHistory();
            Assert.IsTrue(tags.Count == 5757);
        }

        [TestMethod()]
        public void createHistoryTest()
        {
            history h = history.create();
            h.dataQuality = "ok";
            h.value = "134.3";
            h.timestamp = DateTime.UtcNow;
            Assert.IsTrue(h.type.Equals(MongoBase.TYPE_HISTORY));
            Assert.AreEqual(h._id, h.idd);
            mongoHelper.insertHistory(h);
        }


    }
}