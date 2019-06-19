using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learn_combining_WebAPI_with_MVC.ViewModel
{
    public class HomeIndexViewModel
    {
        public int GigId { get; set; }

        [Column(TypeName = "date")]
        public DateTime GigDate { get; set; }

        public bool Booked { get; set; }
    }
}