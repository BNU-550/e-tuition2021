using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.Lessons
{
    public class IndexModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public IndexModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Lesson> Lesson { get;set; }

        public async Task OnGetAsync()
        {
            Lesson = await _context.Lessons
                .Include(l => l.Student)
                .Include(l => l.TimeSlot).ToListAsync();
        }
    }
}
