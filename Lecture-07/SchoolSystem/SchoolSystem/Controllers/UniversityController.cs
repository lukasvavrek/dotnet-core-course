using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Dtos;
using SchoolSystem.Models;

namespace SchoolSystem.Controllers
{
    [ApiController]
    [Route("api/uni")]
    public class UniversityController : ControllerBase
    {
        private readonly UniversityContext _db;
        
        public UniversityController(UniversityContext db)
        {
            _db = db;
        }
        
        [HttpPost]
        [Route("create")]
        public IActionResult CreateUni([FromBody]UniversityDto university)
        {
            var dbModel = university.ToDb();
            if (dbModel == null)
                return BadRequest();
            
            _db.Universities.Add(dbModel);
            _db.SaveChanges();
            return Ok();
        }
    }
}