using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CodeCraft_Database;

public class OrganizationsModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
