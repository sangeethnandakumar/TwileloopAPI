using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TwileloopAPI
{
    public static class Endpoints
    {
        [FunctionName("info")]
        public static async Task<IActionResult> Info(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            var data = new List<object>();
            for (var i = 0; i <= 10; i++)
            {
                data.Add(new
                {
                    Name = "Sangeeth",
                    Value = i
                });
            }
            return new OkObjectResult(data);
        }

        [FunctionName("info2")]
        public static async Task<IActionResult> Info2(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            var data = new List<object>();
            for (var i = 0; i <= 10; i++)
            {
                data.Add(new
                {
                    Name = "Navaneeth",
                    Value = i
                });
            }
            return new OkObjectResult(data);
        }
    }
}
