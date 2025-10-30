using Microsoft.AspNetCore.Mvc;
using DisasterAlleviationPortal.Data;
using DisasterAlleviationPortal.Models;

public class DonationController : Controller
{
    private readonly AppDbContext _context;

    public DonationController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(string donorName, string resourceType, int quantity)
    {
        var donation = new Donation
        {
            DonorName = donorName,
            ResourceType = resourceType,
            Quantity = quantity
        };

        _context.Donations.Add(donation);
        _context.SaveChanges();

        ViewBag.Message = $"Thank you, {donorName}, for donating {quantity} units of {resourceType}.";

        return View("Index");
    }
}

