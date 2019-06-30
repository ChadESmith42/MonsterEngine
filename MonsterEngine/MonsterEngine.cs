using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MonsterEngine.Models;
using MonsterEngine.Services;
using System.Threading.Tasks;

namespace MonsterEngine
{
    public static class MonsterEngine
    {
        [FunctionName("GetMonster")]
        public static IActionResult GetMonster(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "monster")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            Monster monster = MonsterService.GetMonster();

            return (ActionResult)new OkObjectResult(monster);
        }

        [HttpGet("{playerLevel}")]
        [FunctionName("NextMonster")]
        public static IActionResult NextMonster( [HttpTrigger(AuthorizationLevel.Function, "post", Route ="nextMonster/{playerLevel}")] HttpRequest req, ILogger log, int playerLevel)
        {
            log.LogInformation($"Getting the next monster using playerLevel");
            Monster m = MonsterService.NextMonster(playerLevel);
            return (ActionResult)new ObjectResult(m);
        }

    }
}
