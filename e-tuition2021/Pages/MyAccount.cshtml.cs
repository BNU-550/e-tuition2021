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
        private readonly ApplicationDbContext _context;

        public MyAccountModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Person Person { get; set; }
        
        public async Task<IActionResult> OnGetAsync()
        {
            string email = User.Identity.Name;

            Person = await _context.People
                .Include(p => p.Address)
                .Include(p => p.PaymentCard)
                .FirstOrDefaultAsync(m => m.Email == email);

            ReturnPage.Name = ReturnPage.MY_ACCOUNT;

            if (Person == null)
            {
                return RedirectToPage("People/Create" );
            }

            return Page();
        }
    
    }
}
