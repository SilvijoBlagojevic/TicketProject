namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kundes",
                c => new
                    {
                        KundeID = c.Int(nullable: false, identity: true),
                        Adresse = c.String(),
                        KundeName = c.String(),
                        Strasse = c.String(),
                        PLZ = c.Byte(nullable: false),
                        Ort = c.String(),
                        Telefon = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.KundeID);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketID = c.Int(nullable: false, identity: true),
                        Erstellung = c.DateTime(nullable: false),
                        Anderung = c.DateTime(nullable: false),
                        ZusatzArbeiten = c.DateTime(),
                        Ausfuhrer = c.String(),
                        Nachfolgen = c.String(),
                        Ersteller = c.String(),
                        Kunde_KundeID = c.Int(),
                    })
                .PrimaryKey(t => t.TicketID)
                .ForeignKey("dbo.Kundes", t => t.Kunde_KundeID)
                .Index(t => t.Kunde_KundeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "Kunde_KundeID" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Kundes");
        }
    }
}
