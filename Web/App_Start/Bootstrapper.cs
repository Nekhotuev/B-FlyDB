using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Data.Infrastructure;
using Data.Repositories;
using Service;
using Web.Mappings;

namespace Web
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetContainer();
            AutoMapperConfig.Initialize();
        }

        public static void SetContainer()
        {
            var builder = new ContainerBuilder();

            //controllers registration
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            
            //heplers registration
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            //set repositories dependencies
            builder.RegisterAssemblyTypes(typeof(AirportRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();
            
            //set services dependencies
            builder.RegisterAssemblyTypes(typeof(AirportService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            //TODO: Add dependencies for registration

            builder.RegisterFilterProvider();
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}