namespace GLMainProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDocuments : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clients", newName: "Customers");
            RenameTable(name: "dbo.Produits", newName: "Products");
            RenameTable(name: "dbo.Factures", newName: "Documents");
            DropForeignKey("dbo.DetailFactures", "Facture_ID", "dbo.Factures");
            DropForeignKey("dbo.DetailFactures", "Produit_ID", "dbo.Produits");
            DropIndex("dbo.DetailFactures", new[] { "Facture_ID" });
            DropIndex("dbo.DetailFactures", new[] { "Produit_ID" });
            RenameColumn(table: "dbo.Documents", name: "ClientID", newName: "CustomerID");
            RenameIndex(table: "dbo.Documents", name: "IX_ClientID", newName: "IX_CustomerID");
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
                "dbo.Inventories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateProduction = c.DateTime(nullable: false, precision: 0),
                        DatePeremption = c.DateTime(nullable: false, precision: 0),
                        InStock = c.Int(nullable: false),
                        Product_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.Product_ID)
                .Index(t => t.Product_ID);
            
            AddColumn("dbo.Documents", "Reference", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AddColumn("dbo.Documents", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Documents", "Payed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Documents", "PaymentDate", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.Customers", "Designation", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Adress", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Responsable", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Products", "Referance", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Products", "Designation", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 256, storeType: "nvarchar"));
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 256, storeType: "nvarchar"));
            DropTable("dbo.DetailFactures");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DetailFactures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FactureID = c.String(maxLength: 200, storeType: "nvarchar"),
                        Facture_ID = c.Int(),
                        Produit_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.Inventories", "Product_ID", "dbo.Products");
            DropForeignKey("dbo.DocumentDetails", "Produit_ID", "dbo.Products");
            DropForeignKey("dbo.DocumentDetails", "DocumentID", "dbo.Documents");
            DropIndex("dbo.Inventories", new[] { "Product_ID" });
            DropIndex("dbo.DocumentDetails", new[] { "Produit_ID" });
            DropIndex("dbo.DocumentDetails", new[] { "DocumentID" });
            AlterColumn("dbo.Users", "Password", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Products", "Designation", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Products", "Referance", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Responsable", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Email", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Adress", c => c.String(maxLength: 200, storeType: "nvarchar"));
            AlterColumn("dbo.Customers", "Designation", c => c.String(maxLength: 200, storeType: "nvarchar"));
            DropColumn("dbo.Documents", "PaymentDate");
            DropColumn("dbo.Documents", "Payed");
            DropColumn("dbo.Documents", "TotalAmount");
            DropColumn("dbo.Documents", "Reference");
            DropTable("dbo.Inventories");
            DropTable("dbo.DocumentDetails");
            RenameIndex(table: "dbo.Documents", name: "IX_CustomerID", newName: "IX_ClientID");
            RenameColumn(table: "dbo.Documents", name: "CustomerID", newName: "ClientID");
            CreateIndex("dbo.DetailFactures", "Produit_ID");
            CreateIndex("dbo.DetailFactures", "Facture_ID");
            AddForeignKey("dbo.DetailFactures", "Produit_ID", "dbo.Produits", "ID");
            AddForeignKey("dbo.DetailFactures", "Facture_ID", "dbo.Factures", "ID");
            RenameTable(name: "dbo.Documents", newName: "Factures");
            RenameTable(name: "dbo.Products", newName: "Produits");
            RenameTable(name: "dbo.Customers", newName: "Clients");
        }
    }
}
