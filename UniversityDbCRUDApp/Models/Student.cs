using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityDbCRUDApp.Models
{
    public class Student
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string dept_name { get; set; }
        public int tot_cred { get; set; }
    }
}