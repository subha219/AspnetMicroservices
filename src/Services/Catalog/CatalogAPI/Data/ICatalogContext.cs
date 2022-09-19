using CatalogAPI.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogAPI.Data
{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> products { get; set; }
    }
}
