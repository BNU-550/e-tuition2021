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
    public class IndexModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public IndexModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TimeSlot> TimeSlot { get;set; }

        public async Task OnGetAsync()
        {
            TimeSlot = await _context.TimeSlots
                .Include(t => t.Tutor).ToListAsync();
        }
    }
}
