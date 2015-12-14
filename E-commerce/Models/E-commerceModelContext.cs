using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace E_commerce.Models
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext() : base("EcommerceContext")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}