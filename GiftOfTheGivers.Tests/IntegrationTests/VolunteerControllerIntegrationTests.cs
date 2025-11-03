using DisasterAlleviationPortal.Data;
using DisasterAlleviationPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace GiftOfTheGivers.Tests.IntegrationTests
{
    [TestClass]
    public class VolunteerControllerIntegrationTests
    {
        private AppDbContext _context;
        private VolunteerController _controller;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            _context = new AppDbContext(options);
            _controller = new VolunteerController(_context);
        }

        [TestMethod]
        public void CreateVolunteer_AddsToDatabase()
        {
            var volunteer = new Volunteer
            {
                FullName = "Judith",
                Email = "mulendajudith2018@gmail.com", // Use a dummy email
                PreferredDate = DateTime.Today
            };


            var result = _controller.Create(volunteer) as RedirectToActionResult;

            Assert.AreEqual("Index", result.ActionName);
            Assert.AreEqual(1, _context.Volunteers.Count());
            Assert.AreEqual("Judith", _context.Volunteers.First().FullName);
        }
    }
}
