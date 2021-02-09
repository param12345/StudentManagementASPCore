using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagementASPCore.Data;
using StudentManagementASPCore.Model;

namespace StudentManagementASPCore.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentManagementASPCore.Data.StudentManagementDatabase _context;

        public IndexModel(StudentManagementASPCore.Data.StudentManagementDatabase context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student
                .Include(s => s.Course).ToListAsync();
        }
    }
}
