using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDbCRUDApp.Models;

namespace UniversityDbCRUDApp.DataAccess
{
    interface IStudentRepository
    {
        List<Student> GetStudents(int amount, string sort);

        Student GetSingleStudent(int customerId);

        bool InsertStudent(Student ourStudent);

        bool DeleteStudent(int StudentId);

        bool UpdateStudent(Student ourStudent);

    }
}
