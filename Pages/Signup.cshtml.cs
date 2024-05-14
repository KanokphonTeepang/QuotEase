using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuotEase.Pages
{
    public class SignupModel : PageModel
    {
        [BindProperty]
        public SignUpModel SignUp { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            return RedirectToPage("/Login"); 
        }
    }
}
