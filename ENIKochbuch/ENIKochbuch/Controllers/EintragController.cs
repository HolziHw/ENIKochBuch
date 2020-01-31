using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ENIKochbuch.Controllers
{
    public class EintragController : Controller
    {
        // GET: Eintrag
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult newEntry()
        {
            return View();
        }
    }
}