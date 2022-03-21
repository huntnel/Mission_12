using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_12.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }
        public TimeSlot TimeSlot { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        [Range(1, 15, ErrorMessage = "Group size must between 1 and 15")]
        public int GroupSize { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}
