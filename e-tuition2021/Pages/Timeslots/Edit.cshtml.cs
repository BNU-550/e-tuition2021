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

namespace e_tuition2021.Pages.Timeslots
{
    public class EditModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public EditModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TimeSlot TimeSlot { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TimeSlot = await _context.TimeSlots
                .Include(t => t.Tutor).FirstOrDefaultAsync(m => m.Id == id);

            if (TimeSlot == null)
            {
                return NotFound();
            }
           ViewData["TutorId"] = new SelectList(_context.Tutors, "PersonId", "Discriminator");
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

            _context.Attach(TimeSlot).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeSlotExists(TimeSlot.Id))
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

        private bool TimeSlotExists(int id)
        {
            return _context.TimeSlots.Any(e => e.Id == id);
        }
    }
}
