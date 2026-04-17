using Microsoft.AspNetCore.Mvc;
using Mvc_curso.Infrastructure.Context;

namespace Mvc_curso.Web.Controllers
{
    public class StudentController : Controller
    {   //constructor y variable para acceder a la base de datos
        private readonly AppDbContext db;
        public StudentController(AppDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var students = db.Students.ToList();
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
