namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIDpropertyToVirtualElements : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "Kunde_KundeID" });
            RenameColumn(table: "dbo.Tickets", name: "Kunde_KundeID", newName: "KundeID");
            AddColumn("dbo.Kundes", "TicketID", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "KundeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "KundeID");
            AddForeignKey("dbo.Tickets", "KundeID", "dbo.Kundes", "KundeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "KundeID" });
            AlterColumn("dbo.Tickets", "KundeID", c => c.Int());
            DropColumn("dbo.Kundes", "TicketID");
            RenameColumn(table: "dbo.Tickets", name: "KundeID", newName: "Kunde_KundeID");
            CreateIndex("dbo.Tickets", "Kunde_KundeID");
            AddForeignKey("dbo.Tickets", "Kunde_KundeID", "dbo.Kundes", "KundeID");
        }
    }
}
