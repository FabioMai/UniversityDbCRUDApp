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

        // Foreign keys müssen berücksichtigt werden!!!
        public bool InsertStudent(Student ourStudent)
        {
        //    int rowsAffected = this._db.Execute(@"INSERT Student([id],[name],[dept_name],[tot_cred]) values (@ID, @Name, @DeptName, @TotCred)", new { ID = ourStudent.ID, Name = ourStudent.name, DeptName = ourStudent.dept_name, TotCred = ourStudent.tot_cred });

        //    if (rowsAffected > 0)
        //    {
        //        return true;
        //    }
            return false;
        }


        public bool DeleteStudent(int studentId)
        {
            int rowsAffected = this._db.Execute(@"DELETE FROM [Student] WHERE ID = @ID", new { ID = studentId });

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateStudent(Student ourStudent)
        {
            int rowsAffected = this._db.Execute("UPDATE [Student] SET [Name] = @Name ,[Dept_Name] = @DeptName, [Tot_Cred] = @TotCred WHERE ID = " + ourStudent.ID, ourStudent);

            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }


    }
}