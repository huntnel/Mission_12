using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentsContext context { get; set; }
        public EFAppointmentRepository(AppointmentsContext temp)
        {
            context = temp;
        }
        public IQueryable<Appointment> Appointments => context.Appointments;

        public void SaveAppointment(Appointment a)
        {
            context.SaveChanges();
        }

        public void CreateAppointment(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAppointment(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }
    }
}
