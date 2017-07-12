using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TicketProject.Models;

namespace TicketProject
{
    public class NewTicketKundeViewModel
    {
        public Ticket Ticket { get; set; }
        public IEnumerable<Kunde> Kunden { get; set; }
    }
}