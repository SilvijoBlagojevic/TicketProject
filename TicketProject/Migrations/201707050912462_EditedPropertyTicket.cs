namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedPropertyTicket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes");
            DropForeignKey("dbo.Kundes", "TicketID_TicketID", "dbo.Tickets");
            DropIndex("dbo.Kundes", new[] { "TicketID_TicketID" });
            DropIndex("dbo.Tickets", new[] { "Kunde_KundeID" });
            RenameColumn(table: "dbo.Tickets", name: "Kunde_KundeID1", newName: "KundeID_KundeID");
            RenameIndex(table: "dbo.Tickets", name: "IX_Kunde_KundeID1", newName: "IX_KundeID_KundeID");
            DropColumn("dbo.Kundes", "TicketID_TicketID");
            DropColumn("dbo.Tickets", "Kunde_KundeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Kunde_KundeID", c => c.Int());
            AddColumn("dbo.Kundes", "TicketID_TicketID", c => c.Int());
            RenameIndex(table: "dbo.Tickets", name: "IX_KundeID_KundeID", newName: "IX_Kunde_KundeID1");
            RenameColumn(table: "dbo.Tickets", name: "KundeID_KundeID", newName: "Kunde_KundeID1");
            CreateIndex("dbo.Tickets", "Kunde_KundeID");
            CreateIndex("dbo.Kundes", "TicketID_TicketID");
            AddForeignKey("dbo.Kundes", "TicketID_TicketID", "dbo.Tickets", "TicketID");
            AddForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes", "KundeID");
        }
    }
}
