namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedEnumnData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Status", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Software", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Kategorie", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Zustaendig", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Zustaendig");
            DropColumn("dbo.Tickets", "Kategorie");
            DropColumn("dbo.Tickets", "Software");
            DropColumn("dbo.Tickets", "Status");
        }
    }
}
