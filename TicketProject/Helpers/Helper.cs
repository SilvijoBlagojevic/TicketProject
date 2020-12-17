using System;
using TicketProject.Models;
using TicketProject.ViewModel;

namespace TicketProject.Helpers
{
    public static class Helper
    {
        public static Ticket ConvertTicketVMToTicket(TicketVM ticketVM)
        {
            var ticket = new Ticket();

            ticket.Erstellung = DateTime.Now;
            ticket.Beschreibung = ticketVM.Beschreibung;
            ticket.Kategorie = ticketVM.Kategorie;
            ticket.KundeID = ticketVM.KundeID;
            ticket.Software = ticketVM.Software;
            ticket.Status = ticketVM.Status;
            ticket.Zustaendig = ticketVM.Zustaendig;

            return ticket;
        }

        //ticketDb = ticketView don't working in EF
        public static void SetTicketToDbTicket(Ticket ticketDb, Ticket ticketView)
        {
            ticketDb.Kategorie = ticketView.Kategorie;
            ticketDb.Status = ticketView.Status;
            ticketDb.Software = ticketView.Software;
            ticketDb.Zustaendig = ticketView.Zustaendig;
            ticketDb.Beschreibung = ticketView.Beschreibung;
        }
    }
}