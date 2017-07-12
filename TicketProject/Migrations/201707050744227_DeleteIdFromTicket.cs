namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIdFromTicket : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "KundeID" });
            RenameColumn(table: "dbo.Tickets", name: "KundeID", newName: "Kunde_KundeID");
            AlterColumn("dbo.Tickets", "Kunde_KundeID", c => c.Int());
            CreateIndex("dbo.Tickets", "Kunde_KundeID");
            AddForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes", "KundeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "Kunde_KundeID" });
            AlterColumn("dbo.Tickets", "Kunde_KundeID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Tickets", name: "Kunde_KundeID", newName: "KundeID");
            CreateIndex("dbo.Tickets", "KundeID");
            AddForeignKey("dbo.Tickets", "KundeID", "dbo.Kundes", "KundeID", cascadeDelete: true);
        }
    }
}
