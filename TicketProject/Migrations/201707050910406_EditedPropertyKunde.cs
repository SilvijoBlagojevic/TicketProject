namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedPropertyKunde : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes");
            AddColumn("dbo.Kundes", "TicketID_TicketID", c => c.Int());
            AddColumn("dbo.Tickets", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Software", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Kategorie", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Zustaendig", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Kunde_KundeID1", c => c.Int());
            CreateIndex("dbo.Kundes", "TicketID_TicketID");
            CreateIndex("dbo.Tickets", "Kunde_KundeID1");
            AddForeignKey("dbo.Kundes", "TicketID_TicketID", "dbo.Tickets", "TicketID");
            AddForeignKey("dbo.Tickets", "Kunde_KundeID1", "dbo.Kundes", "KundeID");
            DropColumn("dbo.Kundes", "TicketID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kundes", "TicketID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tickets", "Kunde_KundeID1", "dbo.Kundes");
            DropForeignKey("dbo.Kundes", "TicketID_TicketID", "dbo.Tickets");
            DropIndex("dbo.Tickets", new[] { "Kunde_KundeID1" });
            DropIndex("dbo.Kundes", new[] { "TicketID_TicketID" });
            DropColumn("dbo.Tickets", "Kunde_KundeID1");
            DropColumn("dbo.Tickets", "Zustaendig");
            DropColumn("dbo.Tickets", "Kategorie");
            DropColumn("dbo.Tickets", "Software");
            DropColumn("dbo.Tickets", "Status");
            DropColumn("dbo.Kundes", "TicketID_TicketID");
            AddForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes", "KundeID");
        }
    }
}
