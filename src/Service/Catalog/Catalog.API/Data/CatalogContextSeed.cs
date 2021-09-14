using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProducts = productCollection.Find(p => true).Any();
            if (!existProducts)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }
        public static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                 

            };
        }
    }
}
