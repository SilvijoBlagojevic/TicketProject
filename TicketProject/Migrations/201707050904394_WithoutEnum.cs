namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithoutEnum : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "Status");
            DropColumn("dbo.Tickets", "Software");
            DropColumn("dbo.Tickets", "Kategorie");
            DropColumn("dbo.Tickets", "Zustaendig");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Zustaendig", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Kategorie", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Software", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "Status", c => c.Int(nullable: false));
        }
    }
}
