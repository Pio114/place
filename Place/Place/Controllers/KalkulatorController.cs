using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Place.Controllers
{
    public class KalkulatorController : Controller
    {
        public ActionResult StronaGlownaKalkulatora()
        {
            return View();
        }

        // GET: kalkulator
        public ActionResult Dodaj(int a, int b)
        {
            int suma = a + b;
            return View("Wynik",suma);
        }

        public ActionResult Odejmij(int a, int b)
        {
            int suma = a - b;
            return View("Wynik", suma);
        }

        public ActionResult Mnoz(int a, int b)
        {
            int suma = a * b;
            return View("Wynik", suma);
        }

        public ActionResult Dziel(double a, double b)
        {
            double suma = a / b;
            return View("Wynik", suma);
        }

    }
}