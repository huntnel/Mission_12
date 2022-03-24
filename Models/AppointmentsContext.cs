using Microsoft.EntityFrameworkCore;

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
                new TimeSlot { TimeSlotId = 1, Booked = true, Date = "2022-03-22", Time = "08:00" },
                new TimeSlot { TimeSlotId = 2, Booked = false, Date = "2022-03-22", Time = "09:00" },
                new TimeSlot { TimeSlotId = 3, Booked = false, Date = "2022-03-22", Time = "10:00" },
                new TimeSlot { TimeSlotId = 4, Booked = false, Date = "2022-03-22", Time = "11:00" },
                new TimeSlot { TimeSlotId = 5, Booked = false, Date = "2022-03-22", Time = "12:00" },
                new TimeSlot { TimeSlotId = 6, Booked = false, Date = "2022-03-22", Time = "13:00" },
                new TimeSlot { TimeSlotId = 7, Booked = false, Date = "2022-03-22", Time = "14:00" },
                new TimeSlot { TimeSlotId = 8, Booked = false, Date = "2022-03-22", Time = "15:00" },
                new TimeSlot { TimeSlotId = 22, Booked = false, Date = "2022-03-22", Time = "16:00" },
                new TimeSlot { TimeSlotId = 23, Booked = false, Date = "2022-03-22", Time = "17:00" },
                new TimeSlot { TimeSlotId = 24, Booked = false, Date = "2022-03-22", Time = "18:00" },
                new TimeSlot { TimeSlotId = 25, Booked = false, Date = "2022-03-22", Time = "19:00" },
                new TimeSlot { TimeSlotId = 26, Booked = false, Date = "2022-03-22", Time = "20:00" },

                new TimeSlot { TimeSlotId = 9, Booked = false, Date = "2022-03-23", Time = "08:00" },
                new TimeSlot { TimeSlotId = 10, Booked = false, Date = "2022-03-23", Time = "09:00" },
                new TimeSlot { TimeSlotId = 11, Booked = false, Date = "2022-03-23", Time = "10:00" },
                new TimeSlot { TimeSlotId = 12, Booked = false, Date = "2022-03-23", Time = "11:00" },
                new TimeSlot { TimeSlotId = 13, Booked = false, Date = "2022-03-23", Time = "12:00" },
                new TimeSlot { TimeSlotId = 14, Booked = false, Date = "2022-03-23", Time = "13:00" },
                new TimeSlot { TimeSlotId = 15, Booked = false, Date = "2022-03-23", Time = "14:00" },
                new TimeSlot { TimeSlotId = 16, Booked = false, Date = "2022-03-23", Time = "15:00" },
                new TimeSlot { TimeSlotId = 17, Booked = false, Date = "2022-03-23", Time = "16:00" },
                new TimeSlot { TimeSlotId = 18, Booked = false, Date = "2022-03-23", Time = "17:00" },
                new TimeSlot { TimeSlotId = 19, Booked = false, Date = "2022-03-23", Time = "18:00" },
                new TimeSlot { TimeSlotId = 20, Booked = false, Date = "2022-03-23", Time = "19:00" },
                new TimeSlot { TimeSlotId = 21, Booked = false, Date = "2022-03-23", Time = "20:00" },

                new TimeSlot { TimeSlotId = 27, Booked = false, Date = "2022-03-24", Time = "08:00" },
                new TimeSlot { TimeSlotId = 28, Booked = false, Date = "2022-03-24", Time = "09:00" },
                new TimeSlot { TimeSlotId = 29, Booked = false, Date = "2022-03-24", Time = "10:00" },
                new TimeSlot { TimeSlotId = 30, Booked = false, Date = "2022-03-24", Time = "11:00" },
                new TimeSlot { TimeSlotId = 31, Booked = false, Date = "2022-03-24", Time = "12:00" },
                new TimeSlot { TimeSlotId = 32, Booked = false, Date = "2022-03-24", Time = "13:00" },
                new TimeSlot { TimeSlotId = 33, Booked = false, Date = "2022-03-24", Time = "14:00" },
                new TimeSlot { TimeSlotId = 34, Booked = false, Date = "2022-03-24", Time = "15:00" },
                new TimeSlot { TimeSlotId = 35, Booked = false, Date = "2022-03-24", Time = "16:00" },
                new TimeSlot { TimeSlotId = 36, Booked = false, Date = "2022-03-24", Time = "17:00" },
                new TimeSlot { TimeSlotId = 37, Booked = false, Date = "2022-03-24", Time = "18:00" },
                new TimeSlot { TimeSlotId = 38, Booked = false, Date = "2022-03-24", Time = "19:00" },
                new TimeSlot { TimeSlotId = 39, Booked = false, Date = "2022-03-24", Time = "20:00" },

                new TimeSlot { TimeSlotId = 40, Booked = false, Date = "2022-03-25", Time = "08:00" },
                new TimeSlot { TimeSlotId = 41, Booked = false, Date = "2022-03-25", Time = "09:00" },
                new TimeSlot { TimeSlotId = 42, Booked = false, Date = "2022-03-25", Time = "10:00" },
                new TimeSlot { TimeSlotId = 43, Booked = false, Date = "2022-03-25", Time = "11:00" },
                new TimeSlot { TimeSlotId = 44, Booked = false, Date = "2022-03-25", Time = "12:00" },
                new TimeSlot { TimeSlotId = 45, Booked = false, Date = "2022-03-25", Time = "13:00" },
                new TimeSlot { TimeSlotId = 46, Booked = false, Date = "2022-03-25", Time = "14:00" },
                new TimeSlot { TimeSlotId = 47, Booked = false, Date = "2022-03-25", Time = "15:00" },
                new TimeSlot { TimeSlotId = 48, Booked = false, Date = "2022-03-25", Time = "16:00" },
                new TimeSlot { TimeSlotId = 49, Booked = false, Date = "2022-03-25", Time = "17:00" },
                new TimeSlot { TimeSlotId = 50, Booked = false, Date = "2022-03-25", Time = "18:00" },
                new TimeSlot { TimeSlotId = 51, Booked = false, Date = "2022-03-25", Time = "19:00" },
                new TimeSlot { TimeSlotId = 52, Booked = false, Date = "2022-03-25", Time = "20:00" },

                new TimeSlot { TimeSlotId = 53, Booked = false, Date = "2022-03-26", Time = "08:00" },
                new TimeSlot { TimeSlotId = 54, Booked = false, Date = "2022-03-26", Time = "09:00" },
                new TimeSlot { TimeSlotId = 55, Booked = false, Date = "2022-03-26", Time = "10:00" },
                new TimeSlot { TimeSlotId = 56, Booked = false, Date = "2022-03-26", Time = "11:00" },
                new TimeSlot { TimeSlotId = 57, Booked = false, Date = "2022-03-26", Time = "12:00" },
                new TimeSlot { TimeSlotId = 58, Booked = false, Date = "2022-03-26", Time = "13:00" },
                new TimeSlot { TimeSlotId = 59, Booked = false, Date = "2022-03-26", Time = "14:00" },
                new TimeSlot { TimeSlotId = 60, Booked = false, Date = "2022-03-26", Time = "15:00" },
                new TimeSlot { TimeSlotId = 61, Booked = false, Date = "2022-03-26", Time = "16:00" },
                new TimeSlot { TimeSlotId = 62, Booked = false, Date = "2022-03-26", Time = "17:00" },
                new TimeSlot { TimeSlotId = 63, Booked = false, Date = "2022-03-26", Time = "18:00" },
                new TimeSlot { TimeSlotId = 64, Booked = false, Date = "2022-03-26", Time = "19:00" },
                new TimeSlot { TimeSlotId = 65, Booked = false, Date = "2022-03-26", Time = "20:00" },

                new TimeSlot { TimeSlotId = 66, Booked = false, Date = "2022-03-27", Time = "08:00" },
                new TimeSlot { TimeSlotId = 67, Booked = false, Date = "2022-03-27", Time = "09:00" },
                new TimeSlot { TimeSlotId = 68, Booked = false, Date = "2022-03-27", Time = "10:00" },
                new TimeSlot { TimeSlotId = 69, Booked = false, Date = "2022-03-27", Time = "11:00" },
                new TimeSlot { TimeSlotId = 70, Booked = false, Date = "2022-03-27", Time = "12:00" },
                new TimeSlot { TimeSlotId = 71, Booked = false, Date = "2022-03-27", Time = "13:00" },
                new TimeSlot { TimeSlotId = 72, Booked = false, Date = "2022-03-27", Time = "14:00" },
                new TimeSlot { TimeSlotId = 73, Booked = false, Date = "2022-03-27", Time = "15:00" },
                new TimeSlot { TimeSlotId = 74, Booked = false, Date = "2022-03-27", Time = "16:00" },
                new TimeSlot { TimeSlotId = 75, Booked = false, Date = "2022-03-27", Time = "17:00" },
                new TimeSlot { TimeSlotId = 76, Booked = false, Date = "2022-03-27", Time = "18:00" },
                new TimeSlot { TimeSlotId = 77, Booked = false, Date = "2022-03-27", Time = "19:00" },
                new TimeSlot { TimeSlotId = 78, Booked = false, Date = "2022-03-27", Time = "20:00" },

                new TimeSlot { TimeSlotId = 79, Booked = false, Date = "2022-03-28", Time = "08:00" },
                new TimeSlot { TimeSlotId = 80, Booked = false, Date = "2022-03-28", Time = "09:00" },
                new TimeSlot { TimeSlotId = 81, Booked = false, Date = "2022-03-28", Time = "10:00" },
                new TimeSlot { TimeSlotId = 82, Booked = false, Date = "2022-03-28", Time = "11:00" },
                new TimeSlot { TimeSlotId = 83, Booked = false, Date = "2022-03-28", Time = "12:00" },
                new TimeSlot { TimeSlotId = 84, Booked = false, Date = "2022-03-28", Time = "13:00" },
                new TimeSlot { TimeSlotId = 85, Booked = false, Date = "2022-03-28", Time = "14:00" },
                new TimeSlot { TimeSlotId = 86, Booked = false, Date = "2022-03-28", Time = "15:00" },
                new TimeSlot { TimeSlotId = 87, Booked = false, Date = "2022-03-28", Time = "16:00" },
                new TimeSlot { TimeSlotId = 88, Booked = false, Date = "2022-03-28", Time = "17:00" },
                new TimeSlot { TimeSlotId = 89, Booked = false, Date = "2022-03-28", Time = "18:00" },
                new TimeSlot { TimeSlotId = 90, Booked = false, Date = "2022-03-28", Time = "19:00" },
                new TimeSlot { TimeSlotId = 91, Booked = false, Date = "2022-03-28", Time = "20:00" }
                );
        }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<TimeSlot> TimeSlots { get; set; }
        
    }
}
