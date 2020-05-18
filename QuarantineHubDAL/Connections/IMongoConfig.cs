namespace MVC.Core.Database.Config
{
    public interface IMongoConfig
    {
        string connectionString { get; set; }
        string databaseName { get; set; }
    }
}
