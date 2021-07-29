using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentsAPI.Data;
using StudentsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // Dependency Injection
        private ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Create Endpoints
        [HttpGet]
        public IActionResult ListAllStudents()
        {
            var students = _context.Students.ToList<Student>();

            return new JsonResult(students);
        }
    }
}
