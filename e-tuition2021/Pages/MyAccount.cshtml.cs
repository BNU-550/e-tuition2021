using e_tuition2021.Data;
using e_tuition2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace e_tuition2021.Pages
{
    public class MyAccountModel : PageModel
    {
        private readonly e_tuition2021.Data.ApplicationDbContext _context;

        public MyAccountModel(e_tuition2021.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            string email = User.Identity.Name;

            Person = await _context.People
                .Include(p => p.Address)
                .Include(p => p.PaymentCard).FirstOrDefaultAsync(m => m.Email == email);

            if (Person == null)
            {
                return NotFound();
            }
            ReturnPage.Name = ReturnPage.MY_ACCOUNT;
            return Page();
        }
    
    }
}
