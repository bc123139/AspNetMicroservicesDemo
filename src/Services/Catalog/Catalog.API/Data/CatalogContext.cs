using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("DatabaseSettings:ConectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("DatabaseSettings:ConectionString"));
            Products = database.GetCollection<Product>(configuration.GetValue<string>("DatabaseSettings:Products"));
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
