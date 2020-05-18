namespace MVC.Core.Database.Config
{
    public class MongoConfiguration : IMongoConfig
    {
        public string connectionString { get; set; }
        public string databaseName { get; set; }
    }
}
