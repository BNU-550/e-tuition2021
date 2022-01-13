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
    public class DetailsModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public DetailsModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Tutor Tutor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tutor = await _context.Tutors
                .Include(t => t.Address)
                .Include(t => t.PaymentCard)
                .Include(t => t.Lessons)
                .ThenInclude(t => t.TimeSlot)
                .FirstOrDefaultAsync(m => m.PersonId == id);

            if (Tutor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
