using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TicketProject.Helpers;
using TicketProject.Models;
using TicketProject.ViewModel;

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
            var ticketVM = new TicketVM();
            ViewBag.KundenList = db.Kunden;
            return View("Create", ticketVM);
        }

        // POST: Tickets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598. 

        // to do [Bind(Include = "Erstellung, Status, Software, Kategorie, Zustaendig, Beschreibung, Ticket_KundeID ")] 


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketVM ticketVM)
        {
            if (ModelState.IsValid)
            {
                ticketVM.Erstellung = DateTime.Now;
                var tiket = Helper.ConvertTicketVMToTicket(ticketVM);
                db.Tickets.Add(tiket);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    TempData["messageError"] = string.Format("Fehler! " + ex.Message);
                    return View("Create", ticketVM);
                }

                TempData["message"] = string.Format("Neu Ticket ist hinzugefügt!");
                return RedirectToAction("Index");
            }

            TempData["message"] = string.Format("Fehler! Model ist nicht Valid!");
            return RedirectToAction("Index");
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
        public ActionResult Edit([Bind(Include = "TicketID, Erstellung, Status, Software, Kategorie, Zustaendig, KundeID, Beschreibung ")] Ticket ticketView)
        {
            if (ModelState.IsValid)
            {
                Ticket ticketDb = db.Tickets.FirstOrDefault(x => x.TicketID == ticketView.TicketID);

                if (ticketDb == null)
                {
                    return HttpNotFound();
                }

                Helper.SetTicketToDbTicket(ticketDb, ticketView);

                try
                {
                    db.Entry(ticketDb).State = EntityState.Modified;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    TempData["messageError"] = string.Format("Ticket kann nicht gespeichert werden! " + ex.Message);
                    return View("Edit", ticketView);
                }

                TempData["message"] = string.Format("Ticket: {0}, Kundenname: {1} ist geändert", ticketDb.TicketID, ticketDb.Kunde.KundeName);
                return RedirectToAction("Index");
            }
            TempData["messageError"] = string.Format("Fehler! Model ist nicht Valid!");
            return RedirectToAction("Index");
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

            try
            {
                db.Tickets.Remove(ticket);
                db.SaveChanges();
                TempData["message"] = string.Format("Ticket: {0}, Kundenname: {1} ist gelöscht.", ticket.TicketID, ticket.Kunde.KundeName);

            }
            catch (Exception ex)
            {
                TempData["messageError"] = string.Format("Fehler! " + ex.Message);
            }

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
