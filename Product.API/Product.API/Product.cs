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
        String sku;
        String title;
        String description;
        Decimal price;
        Decimal cost;

        public Product()
        {

        }
        public Product(int id, String sku, String title, String theDescription, Decimal thePrice, Decimal theCost)
        {
            this.productId = id;
            this.sku = sku;
            this.title = title;
            this.description = theDescription;
            this.cost = theCost;
            this.price = thePrice;
        }

        [DataMember]
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        [DataMember]
        public string Sku
        {
            get { return sku; }
            set { sku = value; }
        }

        [DataMember]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [DataMember]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        public Decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        [DataMember]
        public Decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}