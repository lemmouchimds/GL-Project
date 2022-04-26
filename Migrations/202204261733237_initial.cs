﻿namespace GLMainProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Designation = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Responsable = c.String(),
                        IsRevendeur = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Referance = c.String(),
                        Designation = c.String(),
                        ValNutritionnelle = c.Double(nullable: false),
                        PoidsNet = c.Double(nullable: false),
                        CoutRevient = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GainSouaite = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discriminator = c.String(nullable: false, maxLength: 128),
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
                        Username = c.String(),
                        Password = c.String(),
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
