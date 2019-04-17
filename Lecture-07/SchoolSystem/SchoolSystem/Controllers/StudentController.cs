using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Dtos;
using SchoolSystem.Models;
using System.Linq;

namespace SchoolSystem.Controllers
{
    [ApiController]
    [Route("api/stud")]
    public class StudentController : ControllerBase
    {
        private readonly UniversityContext _db;
        
        public StudentController(UniversityContext db)
        {
            _db = db;
        }
        
        [HttpPost]
        [Route("create/at/{universityId:int}")]
        public IActionResult CreateUni(int universityId, [FromBody]StudentDto studentDto)
        {
            var university = _db.Universities.SingleOrDefault(u => u.UniversityId == universityId);
            if (university == null)
                return BadRequest("University not found!");
            
            var student = studentDto.ToDb();
            if (student == null)
                return BadRequest("Invalid student!");

            student.University = university;
            
            _db.Students.Add(student);
            _db.SaveChanges();
            return Ok();
        }
    }
}