using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Learn_combining_WebAPI_with_MVC.Models
{
    public class Attendance
    {
        public Gig Gig { get; set; }
        public ApplicationUser Attendee { get; set; }

        [Key]
        [Column(Order = 0)]
        public int GigId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string AttendeeId { get; set; }
    }
}