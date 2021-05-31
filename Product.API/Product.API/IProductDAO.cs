using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.API
{
    public interface IProductDAO
    {
        List<Product> getAllProducts();
        Product createProduct(Product product);
        String deleteProduct(Product product);
        Product getProductById(int id);
        Product updateProduct(Product product);
        

    }
}
