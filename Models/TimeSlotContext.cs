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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimeSlot>()
                .HasKey(t => new { t.Time, t.Date });
        }

        public virtual DbSet<TimeSlot> TimeSlots { get; set; }

        /*internal class MyContext : DbContext
        {
            public DbSet<Blog> Blogs { get; set; }

            #region Required
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Blog>()
                    .Property(b => b.Url)
                    .IsRequired();
            }
            #endregion
        }*/
    }
}
