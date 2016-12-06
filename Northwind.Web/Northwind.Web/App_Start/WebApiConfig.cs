﻿using Northwind.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;

namespace Northwind.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //// Web API configuration and services

            //// Web API routes
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            var builder = new ODataConventionModelBuilder();

            builder.EntitySet<Category>("Categories");
            builder.EntitySet<Customer>("Customers");
            builder.EntitySet<CustomerDemographic>("CustomerDemographics");
            builder.EntitySet<Employee>("Employees");
            builder.EntitySet<Order>("Orders");
            builder.EntitySet<Order_Detail>("Order_Details");
            builder.EntitySet<Product>("Products");
            builder.EntitySet<Region>("Regions");
            builder.EntitySet<Shipper>("Shippers");
            builder.EntitySet<Supplier>("Suppliers");
            builder.EntitySet<Territory>("Territories");

            config.MapODataServiceRoute("ODataRoute", null, builder.GetEdmModel());
        }
    }
}
