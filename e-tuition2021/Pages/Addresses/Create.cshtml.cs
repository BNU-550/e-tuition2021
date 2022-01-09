using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using e_tuition2021.Data;
using e_tuition2021.Models;
using Microsoft.EntityFrameworkCore;

namespace e_tuition2021.Pages.Addresses
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Address Address { get; set; }
        
        [BindProperty]
        public Person Person { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id !=null)
            {
                Person = await _context.People
                    .Include(p => p.Address)
                    .Include(p => p.PaymentCard)
                    .FirstOrDefaultAsync(m => m.PersonId == id);
            }

            return Page();
        }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Addresses.Add(Address);
            await _context.SaveChangesAsync();

            if(Person != null)
            {
                Person.AddressId = Address.Id;
                _context.Attach(Person).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }


            return RedirectToPage(ReturnPage.Name);
        }
    }
}
