using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagementASPCore.Data;
using StudentManagementASPCore.Model;

namespace StudentManagementASPCore.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly StudentManagementASPCore.Data.StudentManagementDatabase _context;

        public DetailsModel(StudentManagementASPCore.Data.StudentManagementDatabase context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.Id == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
