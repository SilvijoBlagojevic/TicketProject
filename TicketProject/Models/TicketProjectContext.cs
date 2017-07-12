using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketProject.Models
{
    public class TicketProjectContext : DbContext
    {
        public TicketProjectContext() : base("TicketProject")
        {
        }

        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}