using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class TimeSlot
    {
        public string Time { get; set; }
        public string Date { get; set; }
        public bool Booked { get; set; }
    }
}
