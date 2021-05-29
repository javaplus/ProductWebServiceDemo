using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product.API
{
    public class ProductDAO : IProductDAO
    {
        public Product createProduct(Product product)
        {
            Console.WriteLine("In create product!!!");
            return new Product(1, "newProduct");
        }

        public string deleteProduct(Product product)
        {
            return "POOF! It's gone";
        }

        public Product getProductById(int id)
        {
            return new Product(id, "your product sir.");
        }

        public Product updateProduct(Product product)
        {
            return product;
        }
    }
}