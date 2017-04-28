using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind_CRUD_frits.Models;
using System.Data.Entity;

namespace Northwind_CRUD_frits.DAL
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}