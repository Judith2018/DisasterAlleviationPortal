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
        public void SaveVolunteer_IntegrationTest()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            using var context = new AppDbContext(options);
            var controller = new VolunteerController(context);

            var volunteer = new Volunteer { FullName = "Judith",  PreferredDate = DateTime.Today };
            var result = controller.Create(volunteer) as RedirectToActionResult;

            Assert.AreEqual("Index", result.ActionName);
            Assert.AreEqual(1, context.Volunteers.Count());
        }


    }
}
