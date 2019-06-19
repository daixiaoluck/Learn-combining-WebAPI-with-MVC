using Learn_combining_WebAPI_with_MVC.Models;
using System.Web.Http;
using Learn_combining_WebAPI_with_MVC.Dtos;
using System.Linq;
using Microsoft.AspNet.Identity;

namespace Learn_combining_WebAPI_with_MVC.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult PostAttendances(AttendanceDto dto)
        {
            var userId = User.Identity.GetUserId();
            bool already = _context.Attendances
                .Any(a => a.AttendeeId == userId && a.GigId == dto.GigId);
            if (already)
            {
                return BadRequest("You have already booked.");
            }
            else
            {
                Attendance attendance = new Attendance
                {
                    GigId = dto.GigId,
                    AttendeeId = userId
                };
                _context.Attendances.Add(attendance);
                _context.SaveChanges();
                return Ok();
            }
        }
    }
}
