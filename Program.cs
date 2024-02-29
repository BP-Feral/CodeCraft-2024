using MongoDB.Driver;
using CodeCraft_Database;

string connectionString = "mongodb+srv://mihaipricob:cookiemonster123@teamfinder.6leg9ls.mongodb.net/";
string databaseName = "TeamFinder";
string collectionName = "Organizations";

// Setup Connection
var client = new MongoClient(connectionString);

// Select Database
var db = client.GetDatabase(databaseName);

// Select Collection
var collection = db.GetCollection<OrganizationsModel>(collectionName);

// Create an Organization item
var Organization = new OrganizationsModel { Name = "Assist", Address = "Tipografiei 1, Suceava 720043" };

// Insert the item
await collection.InsertOneAsync(Organization);

// Return every record
var results = await collection.FindAsync(_ => true);
foreach (var result in results.ToList())
{
    Console.WriteLine($"{result.ID}: {result.Name} {result.Address}");
}

// https://www.youtube.com/watch?v=exXavNOqaVo - 0:17:25 / 1:10:17