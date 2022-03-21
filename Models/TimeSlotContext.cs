using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class TimeSlotContext : DbContext
    {

        public TimeSlotContext()
        {
        }
        public TimeSlotContext(DbContextOptions<TimeSlotContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TimeSlot> TimeSlots { get; set; }

    }

}
