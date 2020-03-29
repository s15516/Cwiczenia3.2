using Cwiczenia3._1.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia3._1.DAL
{
    public class MockDbService : IDbServices
    {
        private static IEnumerable<Student> _students;
        static MockDbService()
        {
            _students = new List<Student>
            { 
            new Student{StudentID=1, FirstName="Janusz", LastName="Tracz"},
            new Student{StudentID=2, FirstName="Adamm", LastName="Adamski"},
            new Student{StudentID=3, FirstName="Piotr", LastName="Piotrowski"}
            };
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
   
}
