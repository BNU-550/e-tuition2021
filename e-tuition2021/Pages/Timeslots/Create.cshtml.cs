using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Timeslots
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
        ViewData["TutorId"] = new SelectList(_context.Tutors, "PersonId", "Discriminator");
            return Page();
        }

        [BindProperty]
        public TimeSlot TimeSlot { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TimeSlots.Add(TimeSlot);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
