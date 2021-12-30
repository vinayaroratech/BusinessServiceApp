using BusinessServiceApp.Application.Implementation;
using BusinessServiceApp.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace BusinessServiceApp
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string country = req.Query["country"];
            BusinessFactory factory = null;
            switch (country.ToLower())
            {
                case "gb":
                    factory = new BusinessGBFactory();
                    break;
                case "it":
                    factory = new BusinessITFactory();
                    break;
                default:
                    return new BadRequestResult();
            }

            Business business = factory.GetBusiness();

            string responseMessage = $"Hello, {business.CountryCode}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
