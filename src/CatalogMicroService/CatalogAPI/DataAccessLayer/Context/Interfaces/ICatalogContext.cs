using CatalogAPI.EntityLayer;
using MongoDB.Driver;

namespace CatalogAPI.DataAccessLayer.Context.Interfaces
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
