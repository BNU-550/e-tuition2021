using e_tuition2021.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace e_tuition2021.Pages
{
    public class TutorSignInModel : PageModel
    {
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public Tutor Tutor { get; set; }

        public void OnGet()
        {
        }
    }
}
