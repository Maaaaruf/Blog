using Autofac;
using Autofac.Integration.Mvc;
using Blog.Framework.Modules;
using Blog.Framework.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Blog.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //var builder = new ContainerBuilder();
            //var connectionStringName = "DefaultConnection";

            ////Registering Dependency
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterFilterProvider();
            //builder.RegisterSource(new ViewRegistrationSource());
            
            ////Module for Framework
            //builder.RegisterModule(new FrameworkModule(connectionStringName));
            ////Module for Web
            //builder.RegisterModule(new FrameworkModule(connectionStringName));

            //var container = builder.Build();

            //DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}
