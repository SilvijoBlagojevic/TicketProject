using System;
using System.ComponentModel.DataAnnotations;

namespace TicketProject.Models
{
    public class Ticket
    {       
        public int TicketID { get; set; }

        [Required]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Erstellung { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public Software Software { get; set; }

        [Required]
        public Kategorie Kategorie { get; set; }

        [Required]
        public Zustaendig Zustaendig { get; set; }


        [Required(ErrorMessage = "Error")]
        public int KundeID { get; set; }

        public virtual Kunde Kunde { get; set; }

        public string Beschreibung { get; set; }

    }

    public enum Status
    {
        Neu,
        Erledigt,
        Aktiv,
        Breitstehen

    }

    public enum Software
    {
        Mobile,
        Cloud,
        PC
    }

    public enum Kategorie
    {
        Software,
        Drivers,
        Fehler
    }

    public enum Zustaendig
    {
            I,
            II,
            III
    }

}