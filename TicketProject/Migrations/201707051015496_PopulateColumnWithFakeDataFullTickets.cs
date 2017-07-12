namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateColumnWithFakeDataFullTickets : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/19/2017 15:00:00', '1/19/2017 16:00:00', null , ' ',  '872 Test',  ' ', 1, 1, 2, 0, 22)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/20/2017 15:00:00', '1/20/2017 16:00:00', null , ' ',  '241 Test',  ' ', 0, 2, 0, 1, 1)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('2/19/2017 15:00:00', '2/19/2017 16:00:00', null , ' ',  '442 Test',  ' ', 3, 2, 2, 2, 6)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('6/19/2017 15:00:00', '6/19/2017 16:00:00', null , ' ',  '112 Test',  ' ', 3, 0, 1, 0, 2)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('3/18/2017 15:00:00', '3/18/2017 16:00:00', null , ' ',  '552 Test',  ' ', 2, 0, 2, 0, 3)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('4/19/2017 15:00:00', '4/19/2017 16:00:00', null , ' ',  '332 Test',  ' ', 1, 2, 0, 1, 4)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/15/2017 15:00:00', '1/18/2017 16:00:00', null , ' ',  '432 Test',  ' ', 1, 0, 2, 1, 5)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/19/2017 15:00:00', '1/20/2017 16:00:00', null , ' ',  '132 Test',  ' ', 0, 2, 1, 2, 6)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('6/19/2017 15:00:00', '6/20/2017 16:00:00', null , ' ',  '223 Test',  ' ', 0, 0, 2, 2, 7)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('3/03/2017 15:00:00', '3/20/2017 16:00:00', null , ' ',  '200 Test',  ' ', 1, 2, 0, 2, 8)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('3/19/2017 15:00:00', '4/19/2017 16:00:00', null , ' ',  '002 Test',  ' ', 0, 0, 2, 0, 9)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/25/2017 15:00:00', '1/25/2017 16:00:00', null , ' ',  '032 Test',  ' ', 1, 2, 2, 0, 10)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('6/30/2017 15:00:00', '6/30/2017 16:00:00', null , ' ',  '322 Test',  ' ', 2, 0, 1, 1, 11)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/03/2017 15:00:00', '1/03/2017 16:00:00', null , ' ',  '052 Test',  ' ', 1, 2, 2, 1, 12)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('6/04/2017 15:00:00', '6/04/2017 16:00:00', null , ' ',  '092 Test',  ' ', 2, 1, 0, 1, 13)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('3/05/2017 15:00:00', '3/05/2017 16:00:00', null , ' ',  '332 Test',  ' ', 1, 2, 1, 1, 14)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/19/2017 15:00:00', '1/19/2017 16:00:00', null , ' ',  '232 Test',  ' ', 2, 1, 2, 2, 15)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/19/2017 15:00:00', '1/19/2017 16:00:00', null , ' ',  '129 Test',  ' ', 1, 2, 2, 2, 16)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('4/06/2017 15:00:00', '4/06/2017 16:00:00', null , ' ',  '299 Test',  ' ', 0, 1, 1, 2, 17)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/11/2017 15:00:00', '1/11/2017 16:00:00', null , ' ',  '278 Test',  ' ', 0, 1, 2, 2, 18)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/19/2017 15:00:00', '1/19/2017 16:00:00', null , ' ',  '247 Test',  ' ', 0, 2, 1, 0, 19)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('4/17/2017 15:00:00', '4/17/2017 16:00:00', null , ' ',  '230 Test',  ' ', 0, 0, 2, 1, 20)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('1/19/2017 15:00:00', '1/19/2017 16:00:00', null , ' ',  '902 Test',  ' ', 0, 2, 0, 1, 21)");
            Sql("INSERT INTO Tickets (Erstellung, Anderung, ZusatzArbeiten, Ausfuhrer, Nachfolgen,  Ersteller, Status, Software, Kategorie, Zustaendig, KundeID) VALUES ('5/25/2017 15:00:00', '5/25/2017 16:00:00', null , ' ',  '872 Test',  ' ', 2, 1, 2, 0, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
