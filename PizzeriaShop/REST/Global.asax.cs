﻿using Autofac;
using Autofac.Integration.WebApi;
using Infraestructures.UOW;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace REST
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;

            // Registra los controllers automaticamente si la nomenclatura terminan en Controller
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            //El resto se registran manualmente
            builder.Register(c => new UnitOfWork()).As<IUow>().InstancePerRequest();
            builder.RegisterType<PizzaService>().InstancePerRequest();


            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);



        }
    }
}
