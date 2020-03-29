using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia3._1.Controllers.Models;
namespace Cwiczenia3._1.DAL
{
    public interface IDbServices
    {
        public IEnumerable<Controllers.Models.Student> GetStudents();
    }
}
