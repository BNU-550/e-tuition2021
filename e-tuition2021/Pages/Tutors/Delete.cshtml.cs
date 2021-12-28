using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Tutors
{
    public class DeleteModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public DeleteModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tutor Tutor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor = await _context.Tutors
                .Include(t => t.Address)
                .Include(t => t.PaymentCard).FirstOrDefaultAsync(m => m.PersonId == id);

            if (Tutor == null)
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

            Tutor = await _context.Tutors.FindAsync(id);

            if (Tutor != null)
            {
                _context.Tutors.Remove(Tutor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
