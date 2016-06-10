using ConsoleApplication1.model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.mongo
{
    public class MongoHelper
    {
        private static IMongoDatabase database;


        public MongoHelper(String ip, String dbName)
        {
            //Must register your model classes before connecting to mongo or you wont be able to map the json
            //to the class.
            BsonClassMap.RegisterClassMap<circuits>();
            BsonClassMap.RegisterClassMap<DpLink>();
            BsonClassMap.RegisterClassMap<dps>();
            BsonClassMap.RegisterClassMap<history>();
            BsonClassMap.RegisterClassMap<HistoryLink>();
            BsonClassMap.RegisterClassMap<LocalLink>();
            BsonClassMap.RegisterClassMap<locals>();
            BsonClassMap.RegisterClassMap<RackLink>();
            BsonClassMap.RegisterClassMap<rpps>();
            BsonClassMap.RegisterClassMap<TagLink>();
            BsonClassMap.RegisterClassMap<tags>();
            //connect
            String connectionString = "mongodb://swagger:swagger1234@" + ip + "/" + dbName;
            var client = new MongoClient(connectionString);
            database = client.GetDatabase(dbName);
        }

        public rpps getRpps()
        {
            var col = database.GetCollection<rpps>(MongoBase.TYPE_RPPS);
            var rpp = col.Find<rpps>(new BsonDocument()).First<rpps>();
            return rpp;
        }

        public List<tags> getTagsNoHistory()
        {
            //Dont return the history because this could be a massive array.
            var projection = Builders<tags>.Projection.Exclude("history");
            var col = database.GetCollection<tags>(MongoBase.TYPE_TAGS);
            var allTags = col.Find<tags>(new BsonDocument()).Project<tags>(projection).ToList<tags>();
            return allTags;
        }

        public void insertHistory(history h)
        {
            var col = database.GetCollection<history>(MongoBase.TYPE_HISTORY);
            col.InsertOne(h);
        }
    }
}
