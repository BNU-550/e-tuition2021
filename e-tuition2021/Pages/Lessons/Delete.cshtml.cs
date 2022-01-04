using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Lessons
{
    public class DeleteModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public DeleteModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Lesson Lesson { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lesson = await _context.Lessons
                .Include(l => l.Student)
                .Include(l => l.TimeSlot).FirstOrDefaultAsync(m => m.LessonId == id);

            if (Lesson == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lesson = await _context.Lessons.FindAsync(id);

            if (Lesson != null)
            {
                _context.Lessons.Remove(Lesson);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
