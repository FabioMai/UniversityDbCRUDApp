using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UniversityDbCRUDApp.DataAccess;
using UniversityDbCRUDApp.Models;

namespace UniversityDbCRUDApp.Controllers
{
    public class StudentController : ApiController
    {
        StudentRepository _ourStudentRepository = new StudentRepository();

        // GET: api/Student
        [Route("Students/{amount}/{sort}")]
        [HttpGet]
        public List<Student> Get(int amount, string sort)
        {
            return _ourStudentRepository.GetStudents(amount, sort);
        }


        // GET: api/Student/5
        [Route("Students/{id}")]
        [HttpGet]
        public Student Get(int id)
        {
            return _ourStudentRepository.GetSingleStudent(id);
        }

        // POST: api/Student
        [Route("Students")]
        [HttpPost]
        public bool Post([FromBody]Student ourStudent)
        {
            return _ourStudentRepository.InsertStudent(ourStudent);
        }

        // PUT: api/Student/5
        [Route("Students")]
        [HttpPut]
        public bool Put([FromBody]Student ourStudent)
        {
            return _ourStudentRepository.UpdateStudent(ourStudent);

        }

        // DELETE: api/Student/5
        [Route("Students/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _ourStudentRepository.DeleteStudent(id);
        }
    }
}
