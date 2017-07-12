namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBesch : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "Beschreibung", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "Beschreibung", c => c.String(nullable: false));
        }
    }
}
