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
     
        private readonly IProductDAO _productDAO;

        public ProductService()
        {
            _productDAO = new ProductDAO();
        }
        public ProductService(IProductDAO productDAO)
        {
            _productDAO = productDAO;
        }


        public Product CreateProduct(Product product)
        {
            // TODO: error handling
            return this._productDAO.createProduct(product);
        }

        public string DeleteProduct(Product product)
        {
            // TODO: error handling
            String response = this._productDAO.deleteProduct(product);
            return response;
        }

        public Product GetProduct(int value)
        {
            // TODO: errorhandling
            return this._productDAO.getProductById(value);
        }

        public Product UpdateProduct(Product product)
        {
            return this._productDAO.updateProduct(product);
        }
    }
}
