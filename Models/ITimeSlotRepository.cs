using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public interface ITimeSlotRepository
    {
        IQueryable<TimeSlot> Purchases { get; }

        void SaveTimeSlot(TimeSlot Timeslot);
    }
}
