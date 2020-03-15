using ENIKochbuch.Models;
using ENIKochbuch.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ENIKochbuch.Controllers
{
    public class EintragController : Controller
    {
        private IRepoEntry rep;

        // GET: Eintrag
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult newEntry()
        {
            return View(new Entry());
        }[HttpPost]

        public ActionResult newEntry(Entry entryfromForm)
        {
            if(entryfromForm == null)
            {
                return RedirectToAction("newEntry");
            }

            CheckEntryData(entryfromForm);

            return View();
        }[HttpGet]

        private void CheckEntryData(Entry entryfromForm)
        {
            if(String.IsNullOrEmpty(entryfromForm.Name.Trim()))
            {
                ModelState.AddModelError("Name", "Das Gericht muss einen Namen haben.");
            }
            if(String.IsNullOrEmpty(entryfromForm.Beschreibung.Trim()))
            {
                ModelState.AddModelError("Beschreibung", "Bitte beschreiben Sie ihr Gericht");
            }
            if(entryfromForm.Portionen < 1)
            {
                ModelState.AddModelError("Portionen", "Die Portionen können nicht für 0 Personen sein");
            }

            if(ModelState.IsValid)
            {
                rep = new RepEntryDB();
                rep.Open();
                rep.Insert(entryfromForm);
                rep.Close();
            }
        }
   }
}