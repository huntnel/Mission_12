using Microsoft.AspNetCore.Mvc;
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

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ITimeSlotRepository temp)
        {
            _logger = logger;
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            string date = "03-22-2021";
            var x = new TimeSlotViewModel
            {
                TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                .OrderBy(t => t.Time)
            };
            
            /*var TimeSlots = repo.TimeSlots.Where(t => t.Date == date)
                .OrderBy(t => t.Time).ToList();*/
            return View(x);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
