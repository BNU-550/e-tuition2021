using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;
using Microsoft.AspNetCore.Authorization;

namespace e_tuition2021.Pages.Tutors
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public IndexModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Tutor> Tutor { get;set; }

        public async Task OnGetAsync()
        {
            Tutor = await _context.Tutors
                .Include(t => t.Address)
                .Include(t => t.PaymentCard).ToListAsync();
        }
    }
}
