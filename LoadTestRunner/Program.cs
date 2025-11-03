using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NBomber.Contracts;
using NBomber.CSharp;

class Program
{
    static void Main()
    {
        var httpClient = new HttpClient();

        var scenario = Scenario.Create("volunteer_load", async context =>
        {
            var content = new StringContent("{\"name\":\"Judith\",\"email\":\"test@placeholder.com\",\"preferredDate\":\"2025-10-31\"}", Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:5001/Volunteer/Create", content);
            return response.IsSuccessStatusCode
                ? Response.Ok()
                : Response.Fail();
        });

        NBomberRunner
            .RegisterScenarios(scenario)
            .WithTestSuite("GiftofTheGivers")
            .WithTestName("Volunteer Load Test")
            .WithReportFolder("./nbomber-reports")
            .Run();
    }
}
