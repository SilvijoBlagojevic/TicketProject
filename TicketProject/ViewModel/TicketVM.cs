using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProject.Models;

namespace TicketProject.ViewModel
{
    public class TicketVM
    {
        public int KundeID { get; set; }

        public DateTime Erstellung { get; set; }

        public Status Status { get; set; }

        public Software Software { get; set; }

        public Kategorie Kategorie { get; set; }

        public Zustaendig Zustaendig { get; set; }

        public string Beschreibung { get; set; }
    }
}