namespace MiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Intial_CreateStore : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoryddls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PackSizeddls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PackSize = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Price = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Discount = c.Single(nullable: false),
                        TotalPrice = c.Double(nullable: false),
                        PackId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PackSize_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categoryddls", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.PackSizeddls", t => t.PackSize_Id)
                .Index(t => t.CategoryId)
                .Index(t => t.PackSize_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductDetails", "PackSize_Id", "dbo.PackSizeddls");
            DropForeignKey("dbo.ProductDetails", "CategoryId", "dbo.Categoryddls");
            DropIndex("dbo.ProductDetails", new[] { "PackSize_Id" });
            DropIndex("dbo.ProductDetails", new[] { "CategoryId" });
            DropTable("dbo.ProductDetails");
            DropTable("dbo.PackSizeddls");
            DropTable("dbo.Categoryddls");
        }
    }
}
