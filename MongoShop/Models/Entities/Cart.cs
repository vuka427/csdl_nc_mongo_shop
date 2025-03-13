using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoShop.Models.Entities
{

    public class Cart
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("UserId")]
        public string UserId { get; set; }

        [BsonElement("Items")]
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        [BsonElement("TotalAmount")]
        public decimal TotalAmount { get; set; }
    }
}
