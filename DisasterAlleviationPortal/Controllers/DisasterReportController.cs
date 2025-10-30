using Microsoft.AspNetCore.Mvc;
using DisasterAlleviationPortal.Data;
using DisasterAlleviationPortal.Models;

public class DisasterReportController : Controller
{
    private readonly AppDbContext _context;

    public DisasterReportController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(string location, string description, string severityLevel)
    {
        var report = new DisasterReport
        {
            Location = location,
            Description = description,
            SeverityLevel = severityLevel
        };

        _context.DisasterReports.Add(report);
        _context.SaveChanges();

        ViewBag.Message = $"Disaster reported at {location} with severity: {severityLevel}.";
        return View("Index");
    }
}
