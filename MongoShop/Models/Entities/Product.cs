using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoShop.Models.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("CategoryId")]
        public string CategoryId { get; set; }  

        [BsonElement("Price")]
        public decimal Price { get; set; }

        [BsonElement("Stock")]
        public int Stock { get; set; }

        [BsonElement("Attributes")]
        public Dictionary<string, object> Attributes { get; set; } = new Dictionary<string, object>();  
    }

}
