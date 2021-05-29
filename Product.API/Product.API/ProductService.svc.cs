using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Product.API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        public Product CreateProduct(Product product)
        {
            product.ProductId = 1;
            return product;
        }

        public string DeleteProduct(Product product)
        {
            return "Success";
        }

        public Product GetProduct(int value)
        {
            return new Product(value, "my product");
        }

        public Product UpdateProduct(Product product)
        {
            return product;
        }
    }
}
