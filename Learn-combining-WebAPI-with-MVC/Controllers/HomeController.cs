using Learn_combining_WebAPI_with_MVC.Models;
using System.Web.Mvc;
using System.Linq;
using Learn_combining_WebAPI_with_MVC.ViewModel;
using System.Collections.Generic;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace Learn_combining_WebAPI_with_MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            List<HomeIndexViewModel> homeIndexViews = new List<HomeIndexViewModel>();
            var attendancesQuery = _context.Attendances;
            var gigsQuery = _context.Gigs;
            var userId = User.Identity.GetUserId();
            foreach (var gig in gigsQuery)
            {
                bool booked = attendancesQuery.Any(a => a.GigId == gig.GigId && a.AttendeeId == userId);
                HomeIndexViewModel homeIndexViewModel = new HomeIndexViewModel
                {
                    GigId = gig.GigId,
                    GigDate = gig.GigDate,
                    Booked = booked
                };
                homeIndexViews.Add(homeIndexViewModel);
            }
            return View(homeIndexViews);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}