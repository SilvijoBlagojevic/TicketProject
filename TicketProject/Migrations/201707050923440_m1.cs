namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "KundeID_KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "KundeID_KundeID" });
            RenameColumn(table: "dbo.Tickets", name: "KundeID_KundeID", newName: "KundeID");
            AlterColumn("dbo.Tickets", "KundeID", c => c.Int(nullable: false));
            CreateIndex("dbo.Tickets", "KundeID");
            AddForeignKey("dbo.Tickets", "KundeID", "dbo.Kundes", "KundeID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "KundeID", "dbo.Kundes");
            DropIndex("dbo.Tickets", new[] { "KundeID" });
            AlterColumn("dbo.Tickets", "KundeID", c => c.Int());
            RenameColumn(table: "dbo.Tickets", name: "KundeID", newName: "KundeID_KundeID");
            CreateIndex("dbo.Tickets", "KundeID_KundeID");
            AddForeignKey("dbo.Tickets", "KundeID_KundeID", "dbo.Kundes", "KundeID");
        }
    }
}
