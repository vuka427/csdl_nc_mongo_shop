using AspNetCore.Identity.Mongo.Model;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoShop.Models.Entities
{
    [BsonIgnoreExtraElements]
    public class AppUser : MongoUser
    {
    }
}
