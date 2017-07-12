namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KundeTelefonNmToINT : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kundes", "Telefon", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kundes", "Telefon", c => c.Byte(nullable: false));
        }
    }
}
