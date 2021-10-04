using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Aggregator.Models
{
    public class CatalogModel
    {
        public string Id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string Summary { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public decimal price { get; set; }
    }
}
