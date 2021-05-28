using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace Product.API
{
    [DataContract]
    public class Product
    {
        int productId;
        String title;
        String description;
        double price;
        double cost;

        public Product(int id, String title)
        {
            this.productId = id;
            this.title = title;
        }

        [DataMember]
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        [DataMember]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        

    }
}