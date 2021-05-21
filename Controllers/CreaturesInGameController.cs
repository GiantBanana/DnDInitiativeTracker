using Microsoft.AspNetCore.Mvc;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Services;

namespace DeskSimAPI.Controllers
{

    [Route("Api/CreatureInGame")]
    [ApiController]
    public class CreaturesInGameController : ControllerBase
    {
        private readonly ICreatureInGameService _creatureInGameService;

        public CreaturesInGameController(ICreatureInGameService creatureInGameService)
        {
            _creatureInGameService = creatureInGameService;
        }

        [HttpPost("[action]/")]
        public IActionResult Update([FromForm] CreatureInGameUpdateDto creatureInGameUpdateDto)
        {
            _creatureInGameService.UpdateCreatureInGame(creatureInGameUpdateDto);
            return Ok();   
        }
       
    }
}