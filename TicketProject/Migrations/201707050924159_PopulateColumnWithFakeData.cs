namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateColumnWithFakeData : DbMigration
    {
        public override void Up()
        {
           // Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('1 TestStrasse', '1 Test Name', '1 Test Strase', 111111, ' ', 036111111) ");

        }

        public override void Down()
        {
        }
    }
}
