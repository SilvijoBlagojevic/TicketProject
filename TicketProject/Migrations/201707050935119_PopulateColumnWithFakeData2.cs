namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateColumnWithFakeData2 : DbMigration
    {
        public override void Up()
        {
           // Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/18/2017 12:00:00', '1/18/2017 13:00:00', null , ' ',  '1 Test',  ' ', 0, 1, 2, 3, 12)");

        }

        public override void Down()
        {
        }
    }
}
