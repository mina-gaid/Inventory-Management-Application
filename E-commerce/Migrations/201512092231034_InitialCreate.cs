namespace E_commerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Email = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        County = c.String(),
                        Joined = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        SupplierId = c.String(),
                        Name = c.String(),
                        Type = c.String(),
                        Price = c.Int(nullable: false),
                        Customer_CustomerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        ProductId = c.String(),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.SupplierProducts",
                c => new
                    {
                        Supplier_SupplierId = c.String(nullable: false, maxLength: 128),
                        Product_ProductId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Supplier_SupplierId, t.Product_ProductId })
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId, cascadeDelete: true)
                .Index(t => t.Supplier_SupplierId)
                .Index(t => t.Product_ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.SupplierProducts", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.SupplierProducts", "Supplier_SupplierId", "dbo.Suppliers");
            DropIndex("dbo.SupplierProducts", new[] { "Product_ProductId" });
            DropIndex("dbo.SupplierProducts", new[] { "Supplier_SupplierId" });
            DropIndex("dbo.Products", new[] { "Customer_CustomerId" });
            DropTable("dbo.SupplierProducts");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}
