using MongoDB.Driver;

namespace DotNetCoreApp.Services
{
    public class MongoContext 
    {
        public readonly IMongoDatabase db;
        public MongoContext(string connectionStr)
        {
            var mongoClient = new MongoClient(connectionStr);
            db = mongoClient.GetDatabase("CompanyDB");
        }
    }
}