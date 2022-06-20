using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentoRide.Models;
namespace RentoRide.Controllers
{
    public class carlistController : Controller
    {
        // GET: carlist
        public ActionResult rentCar()
        {
            var car = new Car() { carModel = "Mercedes"};

            return View(car);
        }
    }
}