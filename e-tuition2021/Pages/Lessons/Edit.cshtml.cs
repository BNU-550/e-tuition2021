using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Lessons
{
    public class EditModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public EditModel(e_tuition2021.Data.ApplicationDbContext context)
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
           ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentName");
           ViewData["TimeSlotId"] = new SelectList(_context.TimeSlots, "Id", "Id");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lesson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LessonExists(Lesson.LessonId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LessonExists(int id)
        {
            return _context.Lessons.Any(e => e.LessonId == id);
        }
    }
}
