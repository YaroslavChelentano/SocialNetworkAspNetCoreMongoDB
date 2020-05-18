using MongoDB.Bson.Serialization.Attributes;

namespace Quarantine.Entities
{
    public class Subscriber
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("nickname")]
        public string Nickname { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("image")]
        public string Image { get; set; }
    }
}