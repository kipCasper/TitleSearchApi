using TitleSearchApi.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System;
using MongoDB.Bson;

namespace TitleSearchApi.Services
{
    public class TitleService
    {
        private readonly IMongoCollection<Title> _titles;
        private readonly IMongoCollection<BsonDocument> _documents;

        public TitleService(ITurnerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _titles = database.GetCollection<Title>("Titles");

            _documents = database.GetCollection<BsonDocument>("Titles");
        }

        public List<Title> Get() =>
            _titles.Find(title => true).ToList();

        public Title Get(string id)
        {
            return _titles.Find<Title>(title => title.Id == id).FirstOrDefault();
        }
    }
}