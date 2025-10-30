using DisasterAlleviationPortal.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiftOfTheGivers.Tests
{
    [TestClass]
    public class DonationServiceTests
    {
        [TestMethod]
        public void ValidateDonation_ValidInput_ReturnsTrue()
        {
            var service = new DonationService();
            var result = service.ValidateDonation("Water", 10);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateDonation_ZeroQuantity_ReturnsFalse()
        {
            var service = new DonationService();
            var result = service.ValidateDonation("Water", 0);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateDonation_NegativeQuantity_ReturnsFalse()
        {
            var service = new DonationService();
            var result = service.ValidateDonation("Water", -5);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateDonation_EmptyItem_ReturnsFalse()
        {
            var service = new DonationService();
            var result = service.ValidateDonation("", 5);
            Assert.IsFalse(result);
        }
    }
}
