using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using System;
using System.Threading;

public class LoginUITests : IDisposable
{
    private readonly IWebDriver driver;

    public LoginUITests()
    {
        var options = new ChromeOptions();

        // Use headless mode in Azure Pipelines
        if (Environment.GetEnvironmentVariable("CI") == "true")
        {
            options.AddArgument("--headless");
            options.AddArgument("--disable-gpu");
        }

        driver = new ChromeDriver(options);
    }

    [Fact]
    public void Login_ShouldRedirectToDashboard()
    {
        try
        {
            driver.Navigate().GoToUrl("https://localhost:7058/Login");
            Thread.Sleep(2000); // Wait for page to settle

            // Simulate typing email character by character
            var emailField = driver.FindElement(By.Name("email"));
            foreach (char c in "test@example.com")
            {
                emailField.SendKeys(c.ToString());
                Thread.Sleep(150); // Delay between keystrokes
            }

            Thread.Sleep(1000); // Pause before typing password

            // Simulate typing password character by character
            var passwordField = driver.FindElement(By.Name("password"));
            foreach (char c in "Test@1234")
            {
                passwordField.SendKeys(c.ToString());
                Thread.Sleep(150); // Delay between keystrokes
            }

            Thread.Sleep(1000); // Pause before clicking login

            driver.FindElement(By.XPath("//button[text()='Login']")).Click();
            Thread.Sleep(3000); // Wait for message to appear

            var message = driver.FindElement(By.XPath("//*[contains(text(),'Welcome back')]")).Text;
            Assert.Contains("Welcome back", message);

            Thread.Sleep(5000); // Keep browser open for recording
        }
        catch (Exception ex)
        {
            Console.WriteLine("Test failed: " + ex.Message);
            Console.WriteLine(driver.PageSource);
            throw;
        }
    }



    public void Dispose()
    {
        driver.Quit();
    }
}
