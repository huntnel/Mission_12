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
                new TimeSlot { Id = 21, Booked = false, Date = "03-23-2021", Time = "20:00" },

                new TimeSlot { Id = 27, Booked = false, Date = "03-24-2021", Time = "08:00" },
                new TimeSlot { Id = 28, Booked = false, Date = "03-24-2021", Time = "09:00" },
                new TimeSlot { Id = 29, Booked = false, Date = "03-24-2021", Time = "10:00" },
                new TimeSlot { Id = 30, Booked = false, Date = "03-24-2021", Time = "11:00" },
                new TimeSlot { Id = 31, Booked = false, Date = "03-24-2021", Time = "12:00" },
                new TimeSlot { Id = 32, Booked = false, Date = "03-24-2021", Time = "13:00" },
                new TimeSlot { Id = 33, Booked = false, Date = "03-24-2021", Time = "14:00" },
                new TimeSlot { Id = 34, Booked = false, Date = "03-24-2021", Time = "15:00" },
                new TimeSlot { Id = 35, Booked = false, Date = "03-24-2021", Time = "16:00" },
                new TimeSlot { Id = 36, Booked = false, Date = "03-24-2021", Time = "17:00" },
                new TimeSlot { Id = 37, Booked = false, Date = "03-24-2021", Time = "18:00" },
                new TimeSlot { Id = 38, Booked = false, Date = "03-24-2021", Time = "19:00" },
                new TimeSlot { Id = 39, Booked = false, Date = "03-24-2021", Time = "20:00" },

                new TimeSlot { Id = 40, Booked = false, Date = "03-25-2021", Time = "08:00" },
                new TimeSlot { Id = 41, Booked = false, Date = "03-25-2021", Time = "09:00" },
                new TimeSlot { Id = 42, Booked = false, Date = "03-25-2021", Time = "10:00" },
                new TimeSlot { Id = 43, Booked = false, Date = "03-25-2021", Time = "11:00" },
                new TimeSlot { Id = 44, Booked = false, Date = "03-25-2021", Time = "12:00" },
                new TimeSlot { Id = 45, Booked = false, Date = "03-25-2021", Time = "13:00" },
                new TimeSlot { Id = 46, Booked = false, Date = "03-25-2021", Time = "14:00" },
                new TimeSlot { Id = 47, Booked = false, Date = "03-25-2021", Time = "15:00" },
                new TimeSlot { Id = 48, Booked = false, Date = "03-25-2021", Time = "16:00" },
                new TimeSlot { Id = 49, Booked = false, Date = "03-25-2021", Time = "17:00" },
                new TimeSlot { Id = 50, Booked = false, Date = "03-25-2021", Time = "18:00" },
                new TimeSlot { Id = 51, Booked = false, Date = "03-25-2021", Time = "19:00" },
                new TimeSlot { Id = 52, Booked = false, Date = "03-25-2021", Time = "20:00" },

                new TimeSlot { Id = 53, Booked = false, Date = "03-26-2021", Time = "08:00" },
                new TimeSlot { Id = 54, Booked = false, Date = "03-26-2021", Time = "09:00" },
                new TimeSlot { Id = 55, Booked = false, Date = "03-26-2021", Time = "10:00" },
                new TimeSlot { Id = 56, Booked = false, Date = "03-26-2021", Time = "11:00" },
                new TimeSlot { Id = 57, Booked = false, Date = "03-26-2021", Time = "12:00" },
                new TimeSlot { Id = 58, Booked = false, Date = "03-26-2021", Time = "13:00" },
                new TimeSlot { Id = 59, Booked = false, Date = "03-26-2021", Time = "14:00" },
                new TimeSlot { Id = 60, Booked = false, Date = "03-26-2021", Time = "15:00" },
                new TimeSlot { Id = 61, Booked = false, Date = "03-26-2021", Time = "16:00" },
                new TimeSlot { Id = 62, Booked = false, Date = "03-26-2021", Time = "17:00" },
                new TimeSlot { Id = 63, Booked = false, Date = "03-26-2021", Time = "18:00" },
                new TimeSlot { Id = 64, Booked = false, Date = "03-26-2021", Time = "19:00" },
                new TimeSlot { Id = 65, Booked = false, Date = "03-26-2021", Time = "20:00" },

                new TimeSlot { Id = 66, Booked = false, Date = "03-27-2021", Time = "08:00" },
                new TimeSlot { Id = 67, Booked = false, Date = "03-27-2021", Time = "09:00" },
                new TimeSlot { Id = 68, Booked = false, Date = "03-27-2021", Time = "10:00" },
                new TimeSlot { Id = 69, Booked = false, Date = "03-27-2021", Time = "11:00" },
                new TimeSlot { Id = 70, Booked = false, Date = "03-27-2021", Time = "12:00" },
                new TimeSlot { Id = 71, Booked = false, Date = "03-27-2021", Time = "13:00" },
                new TimeSlot { Id = 72, Booked = false, Date = "03-27-2021", Time = "14:00" },
                new TimeSlot { Id = 73, Booked = false, Date = "03-27-2021", Time = "15:00" },
                new TimeSlot { Id = 74, Booked = false, Date = "03-27-2021", Time = "16:00" },
                new TimeSlot { Id = 75, Booked = false, Date = "03-27-2021", Time = "17:00" },
                new TimeSlot { Id = 76, Booked = false, Date = "03-27-2021", Time = "18:00" },
                new TimeSlot { Id = 77, Booked = false, Date = "03-27-2021", Time = "19:00" },
                new TimeSlot { Id = 78, Booked = false, Date = "03-27-2021", Time = "20:00" },

                new TimeSlot { Id = 79, Booked = false, Date = "03-28-2021", Time = "08:00" },
                new TimeSlot { Id = 80, Booked = false, Date = "03-28-2021", Time = "09:00" },
                new TimeSlot { Id = 81, Booked = false, Date = "03-28-2021", Time = "10:00" },
                new TimeSlot { Id = 82, Booked = false, Date = "03-28-2021", Time = "11:00" },
                new TimeSlot { Id = 83, Booked = false, Date = "03-28-2021", Time = "12:00" },
                new TimeSlot { Id = 84, Booked = false, Date = "03-28-2021", Time = "13:00" },
                new TimeSlot { Id = 85, Booked = false, Date = "03-28-2021", Time = "14:00" },
                new TimeSlot { Id = 86, Booked = false, Date = "03-28-2021", Time = "15:00" },
                new TimeSlot { Id = 87, Booked = false, Date = "03-28-2021", Time = "16:00" },
                new TimeSlot { Id = 88, Booked = false, Date = "03-28-2021", Time = "17:00" },
                new TimeSlot { Id = 89, Booked = false, Date = "03-28-2021", Time = "18:00" },
                new TimeSlot { Id = 90, Booked = false, Date = "03-28-2021", Time = "19:00" },
                new TimeSlot { Id = 91, Booked = false, Date = "03-28-2021", Time = "20:00" }
                );
        }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<TimeSlot> TimeSlots { get; set; }
        
    }
}
