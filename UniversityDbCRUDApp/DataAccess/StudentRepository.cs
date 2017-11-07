using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using UniversityDbCRUDApp.Models;

namespace UniversityDbCRUDApp.DataAccess
{
    

    public class StudentRepository :IStudentRepository
    {
        private IDbConnection _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public List<Student> GetStudents(int amount, string sort)
        {
            return this._db.Query<Student>("SELECT TOP " + amount + " [ID],[name],[dept_name],[tot_cred] FROM [Student] ORDER BY ID " + sort).ToList();
        }

        public Student GetSingleStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public bool InsertStudent(Student ourStudent)
        {
            throw new NotImplementedException();
        }

        public bool DeleteStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStudent(Student ourStudent)
        {
            throw new NotImplementedException();
        }

    }
}