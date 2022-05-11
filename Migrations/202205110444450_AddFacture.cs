namespace GLMainProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFacture : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .Index(t => t.ClientID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Factures", "ClientID", "dbo.Clients");
            DropIndex("dbo.Factures", new[] { "ClientID" });
            DropTable("dbo.Factures");
        }
    }
}
