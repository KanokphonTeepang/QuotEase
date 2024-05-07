using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace QuotEase.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Username == "example" && Password == "password")
            {
                // Add logic here for a successful login
                return RedirectToPage("/Home");
            }

            // Implement authentication and handle login failure
            ModelState.AddModelError("", "Invalid login attempt.");
            return Page();
        }


    }
}

