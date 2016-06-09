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
    }
}