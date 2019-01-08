using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FloraGotchiAppV2.Controllers
{
    public class HomeController : Controller
    {
        int HumLv = 87;
        int temp = 22;
        GameScore s;

        public HomeController()
        {
            s = new GameScore();
        }

        public IActionResult Index()
        {
          //  ViewData["GameScore"] = "Score = " + s.GetScore();
            ViewData["HumLv"] = "Humidity level = " + HumLv + "%";
            ViewData["Temp"] = "temperature = " + temp + "degrees";

            return View();
        }

        public IActionResult Page1(int AmountToAdd)
        {

           // s.AddScore(AmountToAdd);

            ViewData["GameScore"] = "Score = ";

            return View();
        }

        [HttpPost]

        public IActionResult UpdateTemp(int Temperatuur)
        {

            PlantContext p = new PlantContext("server=studmysql01.fhict.local;user id=dbi414674;password=Dse56VGQx3;database=dbi414674;");

            //p.UpdateTemp(1,Temperatuur);

            ViewData["Temp"] = p.GetCurrentValues(1);

            return RedirectToAction("Index");



        }

        [HttpPost]

        public IActionResult UpdateHumiity(int Humidity)
        {

            PlantContext p = new PlantContext("server=studmysql01.fhict.local;user id=dbi414674;password=Dse56VGQx3;database=dbi414674;");

         //   p.UpdateTemp(1, Humidity);

            return RedirectToAction("Index");



        }

    }
}