using Microsoft.AspNetCore.Mvc;

public class RegisterController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(string fullName, string email, string password)
    {
        // For now, just show a confirmation message
        ViewBag.Message = $"Registered: {fullName} ({email})";
        return View("Index");
    }
}
