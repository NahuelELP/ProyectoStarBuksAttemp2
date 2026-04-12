using Microsoft.AspNetCore.Mvc;
using Mvc_curso.Infrastructure.Context;

namespace Mvc.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _db;
        public StudentController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        
    }
}
