using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class EFTimeSlotRepository : ITimeSlotRepository
    {
        private AppointmentsContext context;
        public EFTimeSlotRepository(AppointmentsContext temp)
        {
            context = temp;
        }
        public IQueryable<TimeSlot> TimeSlots => context.TimeSlots.Include(x => x);
        public void SaveTimeSlot(TimeSlot Timeslot)
        {
            context.AttachRange(Timeslot);
            context.SaveChanges();
        }
    }
}
