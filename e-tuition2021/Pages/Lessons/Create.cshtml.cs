using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Lessons
{
    public class CreateModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public CreateModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentName");
        ViewData["TimeSlotId"] = new SelectList(_context.TimeSlots, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Lesson Lesson { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Lessons.Add(Lesson);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
