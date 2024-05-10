using System.Collections;
using System.Collections.Generic;
using MongoDB.Driver;
using UnityEngine;

public class MongoExample04 : MonoBehaviour
{
    private void Start()
    {
        string connectionString = "mongodb+srv://mongil:mongil@cluster0.ixxxv9w.mongodb.net/";
        MongoClient mongoClient = new MongoClient(connectionString);
        IMongoDatabase sampleDB = mongoClient.GetDatabase("metaverse");
        var collection = sampleDB.GetCollection<Article>("articles");
    }
}
