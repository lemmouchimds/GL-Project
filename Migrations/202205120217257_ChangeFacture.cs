namespace GLMainProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeFacture : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Factures", t => t.Facture_ID)
                .ForeignKey("dbo.Produits", t => t.Produit_ID)
                .Index(t => t.Facture_ID)
                .Index(t => t.Produit_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetailFactures", "Produit_ID", "dbo.Produits");
            DropForeignKey("dbo.DetailFactures", "Facture_ID", "dbo.Factures");
            DropIndex("dbo.DetailFactures", new[] { "Produit_ID" });
            DropIndex("dbo.DetailFactures", new[] { "Facture_ID" });
            DropTable("dbo.DetailFactures");
        }
    }
}
