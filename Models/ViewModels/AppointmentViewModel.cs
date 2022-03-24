using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models.ViewModels
{
    public class AppointmentViewModel
    {
        public IQueryable<Appointment> Appointments { get; set; }
    }
}
