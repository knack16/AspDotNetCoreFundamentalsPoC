using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductCatalogAPI.Models;

namespace ProductCatalogAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new();
        public IEnumerable<Product> GetAll() => _products;
        public Product Get(int id) => _products.FirstOrDefault(p => p.Id == id);
        public void Add(Product product) => _products.Add(product);
        public void Delete(int id) => _products.RemoveAll(p => p.Id == id);
    }
}