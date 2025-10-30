using Microsoft.AspNetCore.Mvc;

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        // Placeholder stats for now
        ViewBag.VolunteerCount = 12;
        ViewBag.DonationCount = 45;
        ViewBag.DisasterCount = 7;

        return View();
    }
}
