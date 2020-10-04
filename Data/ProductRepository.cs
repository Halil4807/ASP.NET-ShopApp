using System.Collections.Generic;
using System.Linq;
using shopapp.webui.Models;

namespace shopapp.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,Name="Iphone 8", Price=6000, Description="İyi telefon", IsApproved=false, ImageUrl="1.jpg"},
                new Product{ProductId=2,Name="Iphone 9", Price=7000, Description="Nice telefon", IsApproved=true, ImageUrl="2.jpg"},
                new Product{ProductId=3,Name="Iphone X", Price=9000, Description="Çok iyi telefon", IsApproved=true, ImageUrl="3.jpg"},
                new Product{ProductId=4,Name="Iphone 11", Price=10000, Description="Güzel telefon", ImageUrl="4.jpg"}
            };
        }

        public static List<Product> Products
        {
            get { return _products; }
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}