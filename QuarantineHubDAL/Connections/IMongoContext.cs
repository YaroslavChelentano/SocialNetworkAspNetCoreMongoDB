using MongoDB.Driver;
using Quarantine.Entities;

namespace MVC.Core.Database.Config
{
    public interface IMongoContext
    {
        IMongoCollection<Post> Posts { get; }
        IMongoCollection<User> Artists { get; }
    }
}
