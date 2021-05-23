using Microsoft.AspNetCore.Mvc;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Services;

namespace DnDIniativeTracker.Controllers
{

    [Route("Api/Creatures")]
    [ApiController]
    public class CreaturesController : ControllerBase
    {
        private readonly ICreatureService _creatureService;

        public CreaturesController(ICreatureService creatureService)
        {
            _creatureService = creatureService;
        }

        [HttpGet("[action]/{id}/")]
        public IActionResult Delete(int id)
        {
            _creatureService.DeleteCreature(id); 
            return Ok();   
        }
       
    }
}