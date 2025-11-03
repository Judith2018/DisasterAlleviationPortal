using Microsoft.AspNetCore.Mvc;
using DisasterAlleviationPortal.Data;
using DisasterAlleviationPortal.Models;

public class VolunteerController : Controller
{
    private readonly AppDbContext _context;

    public VolunteerController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Volunteer volunteer)
    {
        _context.Volunteers.Add(volunteer);
        _context.SaveChanges(); 
        return RedirectToAction("Index");
    }




    [HttpPost]
    public IActionResult Submit(string fullName, string contactNumber, string availability, DateTime? preferredDate)
    {
        var volunteer = new Volunteer
        {
            FullName = fullName,
            ContactNumber = contactNumber,
            Availability = availability,
            PreferredDate = preferredDate,
            DateSubmitted = DateTime.Now
        };

        _context.Volunteers.Add(volunteer);
        _context.SaveChanges();

        ViewBag.Message = $"Thank you, {fullName}, for volunteering!";
        return View("Index");
    }

}
