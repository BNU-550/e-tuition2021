using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Staffs
{
    public class DetailsModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public DetailsModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Staff Staff { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staff = await _context.Staffs
                .Include(s => s.Address)
                .Include(s => s.PaymentCard).FirstOrDefaultAsync(m => m.PersonId == id);

            if (Staff == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
