using Autofac;
using Autofac.Core;
using Product.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using IContainer = Autofac.IContainer;
using Autofac.Integration.Wcf;


namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (IContainer container = Bootstrapper.RegisterContainerBuilder().Build())
            {
                ServiceHost host = new ServiceHost(typeof(ProductService));

                IComponentRegistration registration;
                if (!container.ComponentRegistry.TryGetRegistration
                   (new TypedService(typeof(IProductService)), out registration))
                {
                    Console.WriteLine("The service contract has not been registered in the container.");
                    Console.ReadLine();
                    Environment.Exit(-1);
                }

                host.AddDependencyInjectionBehavior<IProductService>(container);
                host.Open();
                Console.WriteLine("Host has started");
                Console.ReadLine();

                host.Close();
                Environment.Exit(0);
            }
        }
    }
}
