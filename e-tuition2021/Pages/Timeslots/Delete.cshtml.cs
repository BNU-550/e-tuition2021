using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Timeslots
{
    public class DeleteModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public DeleteModel(e_tuition2021.Data.ApplicationDbContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TimeSlot = await _context.TimeSlots.FindAsync(id);

            if (TimeSlot != null)
            {
                _context.TimeSlots.Remove(TimeSlot);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
