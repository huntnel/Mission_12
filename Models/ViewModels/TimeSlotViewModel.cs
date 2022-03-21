using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models.ViewModels
{
    public class TimeSlotViewModel
    {
        public IQueryable<TimeSlot> TimeSlots { get; set; }
    }
}
