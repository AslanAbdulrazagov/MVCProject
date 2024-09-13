using Microsoft.AspNetCore.Mvc;
using MVCProject.DataAccessLayer;

namespace MVCProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;
        public StudentController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public  IActionResult Index()
        {
            var students= _context.Students.ToList();
            return View(students);
        }
    }
}
