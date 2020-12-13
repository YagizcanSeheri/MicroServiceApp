using CatalogAPI.DataAccessLayer.Context.Interfaces;
using CatalogAPI.DataAccessLayer.Context.Seeding;
using CatalogAPI.DataAccessLayer.Settings.Interfaces;
using CatalogAPI.EntityLayer;
using MongoDB.Driver;

namespace CatalogAPI.DataAccessLayer.Context.Concrete
{
    public class CatalogContext:ICatalogContext
    {
        public CatalogContext(ICatalogDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Products = database.GetCollection<Product>(settings.CollectionName);

            //SeedData
            CatalogContextSeed.SeedData(Products);
        }
       public IMongoCollection<Product> Products { get; }
    }
}
