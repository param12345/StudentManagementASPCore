using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagementASPCore.Model;

namespace StudentManagementASPCore.Data
{
    public class StudentManagementDatabase : DbContext
    {
        public StudentManagementDatabase (DbContextOptions<StudentManagementDatabase> options)
            : base(options)
        {
        }

        public DbSet<StudentManagementASPCore.Model.Course> Course { get; set; }

        public DbSet<StudentManagementASPCore.Model.Student> Student { get; set; }

        
    }
}
