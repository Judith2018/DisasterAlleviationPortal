using DisasterAlleviationPortal.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GiftOfTheGivers.Tests
{
    [TestClass]
    public class LoginValidatorTests
    {
        [TestMethod]
        public void ValidateCredentials_ValidInput_ReturnsTrue()
        {
            var validator = new LoginValidator();
            var result = validator.ValidateCredentials("user@example.com", "secure123");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateCredentials_EmptyEmail_ReturnsFalse()
        {
            var validator = new LoginValidator();
            var result = validator.ValidateCredentials("", "secure123");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateCredentials_ShortPassword_ReturnsFalse()
        {
            var validator = new LoginValidator();
            var result = validator.ValidateCredentials("user@example.com", "123");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ValidateCredentials_InvalidEmailFormat_ReturnsFalse()
        {
            var validator = new LoginValidator();
            var result = validator.ValidateCredentials("userexample.com", "secure123");
            Assert.IsFalse(result);
        }
    }
}
