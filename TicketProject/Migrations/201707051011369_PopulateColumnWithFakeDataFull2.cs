namespace TicketProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateColumnWithFakeDataFull2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('3 TestStrasse', '73 Test Name', '3 Test Strase', 90808, ' '      , 0808098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('6 TestStrasse', '26 Test Name', '62 Test Strase', 57865, ' '  , 6768778) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('2 TestStrasse', '25 Test Name', '2 Test Strase', 222221, ' '       , 03641244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('3 TestStrasse', '35 Test Name', '3 Test Strase', 90808, ' '      , 08088) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('67 TestStrasse', '276 Test Name', '762 Test Strase', 75557, ' '  , 57575757) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('92 TestStrasse', '72 Test Name', '72 Test Strase', 222221, ' '     , 036244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('83 TestStrasse', '731 Test Name', '73 Test Strase', 9080808, ' '   , 08098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('76 TestStrasse', '726 Test Name', '762 Test Strase', 5757757, ' '  , 57575) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('72 TestStrasse', '25 Test Name', '72 Test Strase', 222221, ' '     , 036244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('23 TestStrasse', '375 Test Name', '73 Test Strase', 57575, ' '     , 0808098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('17 TestStrasse', '77 Test Name', '362 Test Strase', 87578578, ' '  , 575757) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('02 TestStrasse', '233 Test Name', '2 Test Strase', 222221, ' '     , 03641244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('03 TestStrasse', '323 Test Name', '3 Test Strase', 9080808, ' '    , 0808098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('06 TestStrasse', '026 Test Name', '62 Test Strase', 5786678, ' ', 676878) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('82 TestStrasse', '625 Test Name', '2 Test Strase', 222221, ' '     , 03641244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('83 TestStrasse', '365 Test Name', '3 Test Strase', 9080808, ' '    , 08098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('687 TestStrasse', '6276 Test Name', '762 Test Strase', 75557, ' ', 57575757) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('928 TestStrasse', '272 Test Name', '72 Test Strase', 222221, ' '   , 03641244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('883 TestStrasse', '736 Test Name', '73 Test Strase', 90808, ' '  , 0808098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('876 TestStrasse', '726 Test Name', '762 Test Strase', 5757757, ' ' , 57575) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('872 TestStrasse', '205 Test Name', '72 Test Strase', 222221, ' '   , 03641244) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('283 TestStrasse', '075 Test Name', '73 Test Strase', 57575, ' '    ,08098) ");
            Sql("INSERT INTO Kundes (Adresse, KundeName, Strasse, PLZ, Ort, Telefon) VALUES ('178 TestStrasse', '077 Test Name', '362 Test Strase', 87578578, ' ',  57575757) ");


        }
        
        public override void Down()
        {
        }
    }
}
