using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission_12.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppointmentsContext _aptContext { get; set; }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            ViewBag.Appointments = _aptContext.Appointments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Appointment a)
        {
            if (ModelState.IsValid)
            {
                _aptContext.Add(a);
                _aptContext.SaveChanges();

                return View("Home", a);
            }
            else
            {
                ViewBag.Appointments = _aptContext.Appointments.ToList();
                return View(a);
            }
        }

        [HttpGet]
        public IActionResult Edit(int appointmentId)
        {
            ViewBag.Categories = _aptContext.Appointments.ToList();
            var aptEntry = _aptContext.Appointments.Single(x => x.AppointmentId == appointmentId);
            return View("SignUp", aptEntry);
        }

        [HttpPost]
        public IActionResult Edit(Appointment a)
        {
            _aptContext.Update(a);
            _aptContext.SaveChanges();

            return RedirectToAction("Appointments");
        }

        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            var aptEntry = _aptContext.Appointments.Single(x => x.AppointmentId == appointmentId);
            return View(aptEntry);
        }

        [HttpPost]
        public IActionResult Delete(Appointment a)
        {
            _aptContext.Appointments.Remove(a);
            _aptContext.SaveChanges();
            return RedirectToAction("Appointments");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
