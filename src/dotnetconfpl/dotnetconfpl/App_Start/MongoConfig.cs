using System;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.IdGenerators;

namespace dotnetconfpl.App_Start
{
    public class MongoConfig
    {
        public static void ConfigureSerialziation()
        {
            // creates string ids generated from object
            BsonSerializer.RegisterIdGenerator(typeof(String), StringObjectIdGenerator.Instance);
        }
    }
}