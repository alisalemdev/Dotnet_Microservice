using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace Catalog.API.Entities
{
    public class Product
    {
        
       
        public ObjectId Id { get; set; }
       
        public string title { get; set; }

        public double price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public Rating rating { get; set; }

    }
    public class Rating
    {
        public double rate { get; set; }
        public double count { get; set; }
    }

}
