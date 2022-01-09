using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using e_tuition2021.Data;
using e_tuition2021.Models;

namespace e_tuition2021.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Person Person { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            string email = User.Identity.Name;
            Person.Email = email;

            _context.People.Add(Person);
            await _context.SaveChangesAsync();

            return RedirectToPage(ReturnPage.Name);
        }
    }
}
