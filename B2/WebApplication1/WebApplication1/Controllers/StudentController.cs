using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly EduDbContext eduDbContext;
        // Buoc 1: tiem phu thuoc. su dung DI

        public StudentController(EduDbContext eduDbContext)
        {
            this.eduDbContext = eduDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var students = await this.eduDbContext.students.ToArrayAsync();
            return View(students);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                this.eduDbContext.Add(student);
                await this.eduDbContext.SaveChangesAsync();
                return Redirect(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View();
            }
            else
            {
                var student = this.eduDbContext.students.SingleOrDefault(x => x.Id == id);
                return View();
            }

        }

    }
}
