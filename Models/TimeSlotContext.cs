using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class TimeSlotContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimeSlot>()
                .HasKey(t => new { t.Time, t.Date });
        }

        public virtual DbSet<TimeSlot> TimeSlots { get; set; }
    }
}
