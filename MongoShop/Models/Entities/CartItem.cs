using MongoDB.Bson.Serialization.Attributes;

namespace MongoShop.Models.Entities
{
    public class CartItem
    {
        [BsonElement("ProductId")]
        public string ProductId { get; set; }

        [BsonElement("Quantity")]
        public int Quantity { get; set; }

        [BsonElement("Price")]
        public decimal Price { get; set; }
    }
}
