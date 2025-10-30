using DisasterAlleviationPortal.Data;
using DisasterAlleviationPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlleviationPortal.Pages.User
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _context;

        public LoginModel(AppDbContext context)
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
            var user = _context.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password);
            if (user == null)
            {
                Message = "Invalid credentials.";
                return Page();
            }

            Message = $"Welcome, {Username}!";
            return RedirectToPage("/Index");
        }
    }
}
