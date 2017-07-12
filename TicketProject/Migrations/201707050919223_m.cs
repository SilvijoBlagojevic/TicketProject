namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kundes", "PLZ", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kundes", "PLZ", c => c.Byte(nullable: false));
        }
    }
}
