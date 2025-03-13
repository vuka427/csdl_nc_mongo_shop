using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoShop.Models.Entities
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("UserId")]
        public string UserId { get; set; }  

        [BsonElement("Products")]
        public List<Product> ProductIds { get; set; } = new List<Product>();

        [BsonElement("TotalAmount")]
        public decimal TotalAmount { get; set; }

        [BsonElement("Address")]
        public decimal Address { get; set; }

        [BsonElement("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
