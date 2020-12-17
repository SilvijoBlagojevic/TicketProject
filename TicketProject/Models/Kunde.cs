using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketProject.Models
{
    public class Kunde
    {
        public string Adresse { get; set; }
        public int KundeID { get; set; }

        [Display(Name = "Kunden name")]
        public string KundeName { get; set; }
        public string Strasse { get; set; }

        public int PLZ { get; set; }

        public string Ort { get; set; }

        public int Telefon { get; set; }

        //public virtual ICollection<Ticket> Tickets { get; set; }
       
    }
}