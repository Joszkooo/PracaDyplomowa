using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_game.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnemyController: ControllerBase
    {
        private readonly IEnemyService _enemyService;

        public EnemyController(IEnemyService enemyService)
        {
            _enemyService = enemyService;
        }

        [HttpGet("GetEnemyBy{Id}")]
        public async Task<IActionResult> GetEnemyById(int Id)
        {
            return Ok(new JsonResult(await _enemyService.GetEnemyById(Id)));
        }
        
        [HttpGet]
        [Route("GetRandomEnemy")]
        public async Task<IActionResult> GetRandomEnemy()
        {
            return Ok(new JsonResult(await _enemyService.GetRandomEnemy()));
        }
    }
}