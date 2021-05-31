using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Product.API
{
    public class ProductDAO : IProductDAO
    {
        public Product createProduct(Product product)
        {
            Console.WriteLine("In create product!!!");
            return new Product(1, "sku", "newProduct", "My desc", 10.00, 9.00);
        }

        public string deleteProduct(Product product)
        {
            return "POOF! It's gone";
        }

        public Product getProductById(int id)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

                builder.DataSource = "barry-product-db.database.windows.net";
                builder.UserID = Environment.GetEnvironmentVariable("dbUser");
                builder.Password = Environment.GetEnvironmentVariable("dbPassword"); ;
                builder.InitialCatalog = "ProductDB";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("\nQuery data example:");
                    Console.WriteLine("=========================================\n");

                    connection.Open();

                    String sql = "SELECT * FROM dbo.PRODUCT";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1}", reader.GetInt32(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return new Product(id,"sku", "your product sir.", "a description", 10.00, 9.00);
        }

        public Product updateProduct(Product product)
        {
            return product;
        }
    }
}