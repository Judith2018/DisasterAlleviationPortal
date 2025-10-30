using System.Diagnostics;
using DisasterAlleviationPortal.Models;
using Microsoft.AspNetCore.Mvc;


public class HomeController : Controller
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
