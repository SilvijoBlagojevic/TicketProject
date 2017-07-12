namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edtedModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Beschreibung", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Beschreibung");
        }
    }
}
