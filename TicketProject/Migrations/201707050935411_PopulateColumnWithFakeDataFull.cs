namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateColumnWithFakeDataFull : DbMigration
    {
        public override void Up()
        {


            //Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('2 TestStrasse', '27 Test Name', '2 Test Strase', 222221, ' '       ,03641244) ");


        }

        public override void Down()
        {
        }
    }
}
