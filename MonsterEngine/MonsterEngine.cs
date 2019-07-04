using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using MonsterEngine.Models;
using MonsterEngine.Services;

namespace MonsterEngine
{

    public static class MonsterEngine
    {

        /// <summary>
        /// Gets a new monster based on player level.
        /// </summary>
        /// <param name="req"></param>
        /// <param name="log"></param>
        /// <param name="playerLevel">Int player level</param>
        /// <returns>Monster object, with params based on player level.</returns>
        [HttpGet("{playerLevel}")]
        [FunctionName("GetMonster")]
        public static IActionResult GetMonster( [HttpTrigger(AuthorizationLevel.Function, "post", Route ="getMonster/{playerLevel}")] HttpRequest req, ILogger log, int playerLevel)
        {

            log.LogInformation($"Getting the next monster using playerLevel");
            Monster m = MonsterService.GetMonster(playerLevel);
            return (ActionResult)new ObjectResult(m);
        }

    }
}
