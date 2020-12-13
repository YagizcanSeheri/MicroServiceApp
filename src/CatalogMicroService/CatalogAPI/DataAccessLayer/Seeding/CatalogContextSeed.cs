using CatalogAPI.EntityLayer;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogAPI.DataAccessLayer.Context.Seeding
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(x => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "1910 Classic Training Gloves",
                    Summary= "The 1910 Classic Training Glove is a modern take on a legendary boxing glove line.",
                    Price = 79.99M,
                    Description = "Built with premium leather construction & ventilated palm, the glove is an elevated classic constructed with a modern fit. Timeless icon of boxing style with laser etched detailing and authentic Everlast logo. The 1910 will fit right in while hitting mitts at...",
                    Category = "Gloves",
                    ImageFile = "everlast.jpg"
                },
                new Product()
                {
                    Name = "Pro Style Training Boxing Gloves",
                    Summary= "The trusted basic. Throw hands like a pro. The Everlast Pro Style Training Gloves are the ultimate choice for all fitness and boxing classes.",
                    Price = 44.99M,
                    Description = "Built with premium leather construction & ventilated palm, the glove is an elevated classic constructed with a modern fit. Timeless icon of boxing style with laser etched detailing and authentic Everlast logo. The 1910 will fit right in while hitting mitts at...",
                    Category = "Gloves",
                    ImageFile = "everlast1.jpg"
                },
                new Product()
                {
                    Name = "Protective Headgear",
                    Summary= "Premium synthetic leather and construction provide long lasting durability..",
                    Price = 39.99M,
                    Description = "Premium synthetic leather and construction provide long lasting durability. Anti-microbial treatment prevents offensive odors and bacterial growth keeping your products safe and smelling fresh. Boxing headgear is imperative for increased training protection. One size fits...",
                    Category = "Protective Equipment",
                    ImageFile = "everlast2.jpg"
                },
                new Product()
                {
                    Name = "Flexcool Hand Wraps",
                    Summary= "180 inches of machine washable synthetic blend material that provides comfort and safety while training. ",
                    Price = 19.99M,
                    Description = "180 inches of machine washable synthetic blend material that provides comfort and safety while training. FlexCool material allows wraps to stretch and provides extra protection to the wrist, hands and knuckles. Ventilated design for increased air flow and breathability. Thumb strap ensures ease of use with a hook and loop closure...",
                    Category = "Hand Wraps",
                    ImageFile = "everlast3.jpg"
                },
            };
        }

    }
}
