namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edtedModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tickets", "Anderung");
            DropColumn("dbo.Tickets", "ZusatzArbeiten");
            DropColumn("dbo.Tickets", "Ausfuhrer");
            DropColumn("dbo.Tickets", "Nachfolgen");
            DropColumn("dbo.Tickets", "Ersteller");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Ersteller", c => c.String());
            AddColumn("dbo.Tickets", "Nachfolgen", c => c.String());
            AddColumn("dbo.Tickets", "Ausfuhrer", c => c.String());
            AddColumn("dbo.Tickets", "ZusatzArbeiten", c => c.DateTime());
            AddColumn("dbo.Tickets", "Anderung", c => c.DateTime(nullable: false));
        }
    }
}
