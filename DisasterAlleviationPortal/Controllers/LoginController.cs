using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(string email, string password)
    {
        // For now, just simulate a login success
        ViewBag.Message = $"Welcome back, {email}!";
        return View("Index");
    }
}
