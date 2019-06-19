using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learn_combining_WebAPI_with_MVC.Models
{
    public class Gig
    {
        public int GigId { get; set; }

        [Column(TypeName = "date")]
        public DateTime GigDate { get; set; }
    }
}