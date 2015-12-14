namespace E_commerce.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using E_commerce.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<E_commerce.Models.EcommerceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "E_commerce.Models.EcommerceContext";
        }

        protected override void Seed(E_commerce.Models.EcommerceContext context)
        {
        context.Suppliers.AddOrUpdate(x => x.SupplierId,
                new Supplier() { SupplierId = "12FRTD", Name = "Jane Austen" },
                new Supplier() { SupplierId = "2", Name = "Charles Dickens" },
                new Supplier() { SupplierId = "3", Name = "Miguel de Cervantes" }
                );

        context.Products.AddOrUpdate(x => x.ProductId,
            new Product()
            {
                ProductId = "12FRTD",
                SupplierId = "1",
                Name = "Northanger Abbey",
                Type = "Electronic",
                Price = 9,
            },
            new Product()
            {
                ProductId = "2",
                SupplierId = "2",
                Name = "Northanger Abbey",
                Type = "Electronic",
                Price = 9,
            },
            new Product()
            {
                ProductId = "3",
                SupplierId = "3",
                Name = "David Copperfield",
                Type = "Electronic",
                Price = 9,
            },
            new Product()
            {
                ProductId = "4",
                SupplierId = "4",
                Name = "Don Quixote",
                Type = "Electronic",
                Price = 9,
            }
            );
    }
    }
}
