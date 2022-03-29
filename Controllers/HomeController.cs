using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission_12.Models;
using Mission_12.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Controllers
{
    public class HomeController : Controller
    {

        private ITimeSlotRepository repo;
        private IAppointmentRepository Arepo;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITimeSlotRepository temp, IAppointmentRepository hunterisachump)
        {
            _logger = logger;
            repo = temp;
            Arepo = hunterisachump;
        }

        // Return the home page
        public IActionResult Index()
        {
            return View();
        }


        //The following two routes are for the form to create an appointment.
        [HttpGet]
        public IActionResult Form(string time, string date, int ts)
        {
            ViewBag.Time = time;
            ViewBag.Date = date;
            ViewBag.ts = ts;
            return View();
        }

        [HttpPost]
        public IActionResult Form(Appointment a, string time, string date, int ts)
        {
            ViewBag.Time = time;
            ViewBag.Date = date;
            ViewBag.ts = ts;
            if (ModelState.IsValid)

            {
                Arepo.CreateAppointment(a);
                Arepo.SaveAppointment(a);
                return View("Index", a);
            }
            else
            {
                ViewBag.Appointments = Arepo.Appointments.Include(x => x.TimeSlot).ToList();
                return View(a);
            }
        }

        // The following route is for displaying the times based on the date that the user selects.
        [HttpGet]
        public IActionResult SignUp()
        {
            //string date = "2022-03-22";
            var x = new TimeSlotViewModel
            {
                //TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                //.OrderBy(t => t.Time)

                TimeSlots = repo.TimeSlots.OrderBy(t => t.Date).OrderBy(t => t.Time)
            };
            
            /*var TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                .OrderBy(t => t.Time).ToList();*/
            return View(x);
        }


        // The following actions are for editing and deleting appointments.
        [HttpGet]
        public IActionResult AppointmentList()
        {
            var x = new AppointmentViewModel
            {
                //TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                //.OrderBy(t => t.Time)
                Appointments = Arepo.Appointments.Include(x => x.TimeSlot).OrderBy(a => a.TimeSlot)
            };
            return View(x);
            
        }
        [HttpGet]
        public IActionResult Edit(int appointmentId)
        {
            ViewBag.Appointments = Arepo.Appointments.ToList();
             
            var aptEntry = Arepo.Appointments.Include(x => x.TimeSlot).Single(x => x.AppointmentId == appointmentId);
            ViewBag.ts = aptEntry.TimeSlotId;
            return View(aptEntry);
        }
        [HttpPost]
        public IActionResult Edit(Appointment a)
        {
            if(ModelState.IsValid)
            {
                Arepo.SaveAppointment(a);
            }
            var x = new AppointmentViewModel
            {
                //TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                //.OrderBy(t => t.Time)
                Appointments = Arepo.Appointments.Include(x => x.TimeSlot).OrderBy(a => a.TimeSlot)
            };
            return RedirectToAction("AppointmentList", x);
        }
        [HttpGet]
        public IActionResult Delete(int appointmentId)
        {
            var aptEntry = Arepo.Appointments.Single(x => x.AppointmentId == appointmentId);
            Arepo.DeleteAppointment(aptEntry);
            var x = new AppointmentViewModel
            {
                //TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                //.OrderBy(t => t.Time)
                Appointments = Arepo.Appointments.Include(x => x.TimeSlot).OrderBy(a => a.TimeSlot)
            };
            return View("AppointmentList", x);
        }
        //[HttpPost]
        //public IActionResult Delete(Appointment a)
        //{
        //    Arepo.DeleteAppointment(a);
        //    Arepo.SaveAppointment(a);
        //    return RedirectToAction("AppointmentList");
        //}
    }
}
