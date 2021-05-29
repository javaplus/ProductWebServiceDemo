using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Product.API
{
    public class Bootstrapper
    {

        public static ContainerBuilder RegisterContainerBuilder()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(c => new ProductDAO()).As<IProductDAO>();
            builder.Register(c => new ProductService
                            (c.Resolve<IProductDAO>())).As<IProductService>();
            return builder;
        }

    }
}