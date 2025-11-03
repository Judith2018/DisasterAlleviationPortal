using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NBomber.Contracts;
using NBomber.CSharp;


namespace GiftOfTheGivers.Tests.LoadTests
{
    internal class VolunteerLoadTest
    {
        public static void Main()
        {
            var httpClient = new HttpClient();

            var step = Step.Create("POST Volunteer", async context =>
            {
                var content = new StringContent("{\"name\":\"Judith\",\"email\":\"test@placeholder.com\",\"preferredDate\":\"2025-10-31\"}", System.Text.Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("https://localhost:5001/Volunteer/Create", content);
                return response.IsSuccessStatusCode
                    ? Response.Ok()
                    : Response.Fail();
            });

            var scenario = ScenarioBuilder.CreateScenario("volunteer_load", step)
                .WithLoadSimulations(Simulation.KeepConstant(50, TimeSpan.FromSeconds(30)));

            NBomberRunner.RegisterScenarios(scenario).Run();
        }
    }
}
