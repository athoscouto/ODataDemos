﻿using Northwind.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace Northwind.Web.Controllers
{
    public class ProductsController : ODataController
    {
        NorthwindDb _context = new NorthwindDb();

        [EnableQuery]
        public IQueryable<Product> Get()
        {
            return _context.Products;
        }

        public Product GetProduct([FromODataUri] int key)
        {
            return _context.Products.Single(p => p.ProductID == key);
        }
    }
}
