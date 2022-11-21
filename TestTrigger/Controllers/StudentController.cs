using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTrigger.Context;

namespace TestTrigger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            var record =  _context.Students.Find(student.Id);
            _context.Students.Update(record);
            return Ok(record);
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            _context.Students.Add(new Student
            {
                Id = 1,
                DisplayName = "Joe"
            });
            _context.SaveChanges();

            var joe = _context.Students.Find(1);
            return Ok(joe.RegistrationDate);
        }
    }
}
