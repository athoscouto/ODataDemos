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
    public class OrderDetailsController : ODataController
    {
        NorthwindDb _context = new NorthwindDb();

        [EnableQuery]
        public IQueryable<Order_Detail> Get()
        {
            return _context.Order_Details;
        }
    }
}
