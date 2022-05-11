namespace GLMainProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(maxLength: 200, storeType: "nvarchar"),
                        Adress = c.String(maxLength: 200, storeType: "nvarchar"),
                        Email = c.String(maxLength: 200, storeType: "nvarchar"),
                        Responsable = c.String(maxLength: 200, storeType: "nvarchar"),
                        IsRevendeur = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Referance = c.String(maxLength: 200, storeType: "nvarchar"),
                        Designation = c.String(maxLength: 200, storeType: "nvarchar"),
                        ValNutritionnelle = c.Double(nullable: false),
                        PoidsNet = c.Double(nullable: false),
                        CoutRevient = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GainSouaite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ProduitDerivee_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Produits", t => t.ProduitDerivee_ID)
                .Index(t => t.ProduitDerivee_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 200, storeType: "nvarchar"),
                        Password = c.String(maxLength: 200, storeType: "nvarchar"),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produits", "ProduitDerivee_ID", "dbo.Produits");
            DropIndex("dbo.Produits", new[] { "ProduitDerivee_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Produits");
            DropTable("dbo.Clients");
        }
    }
}
