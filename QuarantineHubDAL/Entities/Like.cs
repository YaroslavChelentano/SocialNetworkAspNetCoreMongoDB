using MongoDB.Bson.Serialization.Attributes;

namespace Quarantine.Entities
{
    public class Like
    {
        [BsonElement("email")]
        public string Email { get; set; }
    }
}
