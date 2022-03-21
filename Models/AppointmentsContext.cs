using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public partial class AppointmentsContext : DbContext
    {
        public AppointmentsContext()
        {
        }

        public AppointmentsContext(DbContextOptions<AppointmentsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot { Id = 1, Booked = false, Date = "03-22-2021", Time = "08:00" },
                new TimeSlot { Id = 2, Booked = false, Date = "03-22-2021", Time = "09:00" },
                new TimeSlot { Id = 3, Booked = false, Date = "03-22-2021", Time = "10:00" },
                new TimeSlot { Id = 4, Booked = false, Date = "03-22-2021", Time = "11:00" },
                new TimeSlot { Id = 5, Booked = false, Date = "03-22-2021", Time = "12:00" },
                new TimeSlot { Id = 6, Booked = false, Date = "03-22-2021", Time = "13:00" },
                new TimeSlot { Id = 7, Booked = false, Date = "03-22-2021", Time = "14:00" },
                new TimeSlot { Id = 8, Booked = false, Date = "03-22-2021", Time = "15:00" },
                new TimeSlot { Id = 22, Booked = false, Date = "03-22-2021", Time = "16:00" },
                new TimeSlot { Id = 23, Booked = false, Date = "03-22-2021", Time = "17:00" },
                new TimeSlot { Id = 24, Booked = false, Date = "03-22-2021", Time = "18:00" },
                new TimeSlot { Id = 25, Booked = false, Date = "03-22-2021", Time = "19:00" },
                new TimeSlot { Id = 26, Booked = false, Date = "03-22-2021", Time = "20:00" },

                new TimeSlot { Id = 9, Booked = false, Date = "03-23-2021", Time = "08:00" },
                new TimeSlot { Id = 10, Booked = false, Date = "03-23-2021", Time = "09:00" },
                new TimeSlot { Id = 11, Booked = false, Date = "03-23-2021", Time = "10:00" },
                new TimeSlot { Id = 12, Booked = false, Date = "03-23-2021", Time = "11:00" },
                new TimeSlot { Id = 13, Booked = false, Date = "03-23-2021", Time = "12:00" },
                new TimeSlot { Id = 14, Booked = false, Date = "03-23-2021", Time = "13:00" },
                new TimeSlot { Id = 15, Booked = false, Date = "03-23-2021", Time = "14:00" },
                new TimeSlot { Id = 16, Booked = false, Date = "03-23-2021", Time = "15:00" },
                new TimeSlot { Id = 17, Booked = false, Date = "03-23-2021", Time = "16:00" },
                new TimeSlot { Id = 18, Booked = false, Date = "03-23-2021", Time = "17:00" },
                new TimeSlot { Id = 19, Booked = false, Date = "03-23-2021", Time = "18:00" },
                new TimeSlot { Id = 20, Booked = false, Date = "03-23-2021", Time = "19:00" },
                new TimeSlot { Id = 21, Booked = false, Date = "03-23-2021", Time = "20:00" }
                );
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<TimeSlot> TimeSlots { get; set; }

    }
}
