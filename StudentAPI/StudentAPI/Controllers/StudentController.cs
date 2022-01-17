using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentAPI.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        MyContext _context = new MyContext();
        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            _context.Students.Add(value);
            _context.SaveChanges();
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            Student s = _context.Students.Find(id);
            s.Phone = value.Phone;
            s.Course = value.Course;
            _context.Entry(s).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Student s = _context.Students.Find(id);
            _context.Students.Remove(s);
            _context.SaveChanges();
        }
    }
}
