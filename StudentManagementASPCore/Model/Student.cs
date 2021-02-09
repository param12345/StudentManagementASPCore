using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementASPCore.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string student_Name { get; set; }

        public string student_Email { get; set; }


        public string student_Mobile { get; set; }
        public string student_Address { get; set; }

// Foreign Key Definitions where  Course_obj  is the object of  the course class

        public int CourseId { get; set; }

        public Course Course { get; set; }



    }
}
