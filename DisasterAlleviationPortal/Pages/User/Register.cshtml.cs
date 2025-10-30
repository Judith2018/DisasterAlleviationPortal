using DisasterAlleviationPortal.Data;
using DisasterAlleviationPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlleviationPortal.Pages.User
{
    public class RegisterModel : PageModel
    {
        private readonly AppDbContext _context;

        public RegisterModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Message { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                Message = "Username and password are required.";
                return Page();
            }

            if (Password.Length < 8)
            {
                Message = "Password must be at least 8 characters.";
                return Page();
            }

            var exists = _context.Users.Any(u => u.Username == Username);
            if (exists)
            {
                Message = "Username already taken.";
                return Page();
            }

            var user = new DisasterAlleviationPortal.Models.User { Username = Username, Password = Password };
            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToPage("Login");
        }
    }
}
