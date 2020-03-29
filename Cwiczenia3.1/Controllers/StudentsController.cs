using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia3._1.Controllers.Models;
using Cwiczenia3._1.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IDbServices _dbService;
        public StudentsController(IDbServices dbService)
        {
            _dbService = dbService;
        }
          [HttpGet]
          public IActionResult GetStudent()
          {
            return Ok(_dbService.GetStudents());
          } 
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
                return Ok("Kowalski");
            else if (id == 2)
                return Ok("Majewski");
            else
                return NotFound("Nie znaleziono studenta");
        }
       /* [HttpGet]
        public String GetStudent(string orderBy)
        {
            return $"Majkowski, Podolski, Zając sortowanie={orderBy}";
        }
        */
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
           
            return Ok("Aktualizacja zakończona");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Usuwanie zakończone");
        }

    } 
}
    

