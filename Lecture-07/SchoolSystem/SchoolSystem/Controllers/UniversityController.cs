using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Dtos;
using SchoolSystem.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public IActionResult CreateUni([FromBody]UniversityDto universityDto)
        {
            var university = universityDto.ToDb();
            if (university == null)
                return BadRequest();
            
            _db.Universities.Add(university);
            _db.SaveChanges();
            return Ok();
        }

        [HttpGet]
        [Route("all")]
        public IActionResult All()
        {
            var universities = _db.Universities.Select(university => new
            {
                Id = university.UniversityId,
                Name = university.UniName
            });

            return Ok(universities);
        }

        [HttpGet]
        [Route("get/{universityId:int}")]
        public IActionResult GetOne(int universityId)
        {
            var university = _db.Universities
                .Include("Students")
                .SingleOrDefault(u => u.UniversityId == universityId);
            if (university != null)
                return Ok(university);

            return BadRequest("Id not found!");
        }
        
        [HttpDelete]
        [Route("delete/{universityId:int}")]
        public IActionResult Delete(int universityId)
        {
            var university = _db.Universities.SingleOrDefault(u => u.UniversityId == universityId);
            if (university == null) 
                return BadRequest("Id not found!");
            
            _db.Universities.Remove(university);
            _db.SaveChanges();
            return Ok();
        }
        
        [HttpPut]
        [Route("update/{universityId:int}")]
        public IActionResult Update(int universityId, [FromBody]UniversityDto universityDto)
        {
            var university = _db.Universities.SingleOrDefault(u => u.UniversityId == universityId);
            if (university == null) 
                return BadRequest("Id not found!");

            university.UniName = universityDto.UniName;
            _db.Universities.Update(university);
            _db.SaveChanges();
            
            return Ok();
        }
    }
}