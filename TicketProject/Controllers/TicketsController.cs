using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketProject.Models;


namespace TicketProject.Controllers
{
    public class TicketsController : Controller
    {
        private TicketProjectContext db = new TicketProjectContext();

        // GET: Tickets
        public ActionResult Index(string searchString)
        {

            if (searchString != null)
            {
                return View(db.Tickets.Where(x => x.Kunde.KundeName.Contains(searchString)));
            }
            return View(db.Tickets.Include(d => d.Kunde).ToList());
        }

        // GET: Tickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // GET: Tickets/Create
        public ActionResult Create()
        {
            var viewModelkunde = new NewTicketKundeViewModel
            {
                Kunden = db.Kunden.ToList()
            };

            return View("Create", viewModelkunde);
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598. 

        // to do [Bind(Include = "Erstellung, Status, Software, Kategorie, Zustaendig, Beschreibung, Ticket_KundeID ")] 


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(NewTicketKundeViewModel viewModelkunde)
        {
            if (ModelState.IsValid)
            {
                Ticket ticket = new Ticket();
                ticket.KundeID = viewModelkunde.Ticket.KundeID;
                ticket.Kunde = db.Kunden.FirstOrDefault(x => x.KundeID == viewModelkunde.Ticket.KundeID);
                ticket = viewModelkunde.Ticket;
                db.Tickets.Add(ticket);
                db.SaveChanges();
                var neuTicket = db.Tickets.Max(p => p.TicketID);
                TempData["message"] = string.Format("Neu Ticket ist hinzugefügt. Id Ticket ist: {0}", neuTicket.ToString());
                return RedirectToAction("Index");
            }

            TempData["message"] = string.Format("Geht nicht");
            return View("Create", viewModelkunde);
        }

        // GET: Tickets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Ticket ticket = db.Tickets.Find(id);

            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View("Edit", ticket);
        }

        // POST: Tickets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TicketID, Erstellung, Status, Software, Kategorie, Zustaendig, KundeID, Beschreibung ")]  Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                Ticket ticketDb = db.Tickets.FirstOrDefault(x => x.TicketID == ticket.TicketID);

                if (ticketDb == null)
                {
                    return HttpNotFound();
                }

                ticketDb.Kategorie = ticket.Kategorie;
                ticketDb.Status = ticket.Status;
                ticketDb.Software = ticket.Software;
                ticketDb.Zustaendig = ticket.Zustaendig;
                ticketDb.Beschreibung = ticket.Beschreibung;
                db.Entry(ticketDb).State = EntityState.Modified;
                db.SaveChanges();
                TempData["message"] = string.Format("Ticket: {0}, Kundenname: {1} ist geändert", ticketDb.TicketID, ticketDb.Kunde.KundeName);
                return RedirectToAction("Index");
            }
            return View("Edit", ticket);
        }

        // GET: Tickets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket ticket = db.Tickets.Find(id);
            if (ticket == null)
            {
                return HttpNotFound();
            }
            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ticket ticket = db.Tickets.Find(id);
            TempData["message"] = string.Format("Ticket: {0}, Kundenname: {1} ist gelöscht.", ticket.TicketID, ticket.Kunde.KundeName);
            db.Tickets.Remove(ticket);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
