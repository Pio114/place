using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Place.Controllers
{
    public class KalkulatorController : Controller
    {
        // GET: kalkulator
        public ActionResult Dodaj(int a, int b)
        {
            int suma = a + b;
            return View("Wynik",suma);
        }
    }
}