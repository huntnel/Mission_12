using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Time { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public bool Booked { get; set; }
    }
}
