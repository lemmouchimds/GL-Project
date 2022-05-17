namespace GLMainProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(maxLength: 256, storeType: "nvarchar"),
                        Adress = c.String(maxLength: 256, storeType: "nvarchar"),
                        Email = c.String(maxLength: 256, storeType: "nvarchar"),
                        Responsable = c.String(maxLength: 256, storeType: "nvarchar"),
                        IsRevendeur = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Documents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Reference = c.String(maxLength: 256, storeType: "nvarchar"),
                        CustomerID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 0),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payed = c.Boolean(nullable: false),
                        PaymentDate = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "dbo.DocumentDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Label = c.String(maxLength: 256, storeType: "nvarchar"),
                        Offset = c.Int(nullable: false),
                        Marging = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DocumentID = c.Int(nullable: false),
                        Produit_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Documents", t => t.DocumentID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Produit_ID)
                .Index(t => t.DocumentID)
                .Index(t => t.Produit_ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Referance = c.String(maxLength: 256, storeType: "nvarchar"),
                        Designation = c.String(maxLength: 256, storeType: "nvarchar"),
                        ValNutritionnelle = c.Double(nullable: false),
                        PoidsNet = c.Double(nullable: false),
                        CoutRevient = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GainSouaite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ProduitDerivee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProduitDerivee_ID)
                .Index(t => t.ProduitDerivee_ID);
            
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        DateProduction = c.DateTime(nullable: false, precision: 0),
                        DatePeremption = c.DateTime(nullable: false, precision: 0),
                        InStock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 256, storeType: "nvarchar"),
                        Password = c.String(maxLength: 256, storeType: "nvarchar"),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentDetails", "Produit_ID", "dbo.Products");
            DropForeignKey("dbo.Products", "ProduitDerivee_ID", "dbo.Products");
            DropForeignKey("dbo.Inventories", "ProductID", "dbo.Products");
            DropForeignKey("dbo.DocumentDetails", "DocumentID", "dbo.Documents");
            DropForeignKey("dbo.Documents", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Inventories", new[] { "ProductID" });
            DropIndex("dbo.Products", new[] { "ProduitDerivee_ID" });
            DropIndex("dbo.DocumentDetails", new[] { "Produit_ID" });
            DropIndex("dbo.DocumentDetails", new[] { "DocumentID" });
            DropIndex("dbo.Documents", new[] { "CustomerID" });
            DropTable("dbo.Users");
            DropTable("dbo.Inventories");
            DropTable("dbo.Products");
            DropTable("dbo.DocumentDetails");
            DropTable("dbo.Documents");
            DropTable("dbo.Customers");
        }
    }
}
