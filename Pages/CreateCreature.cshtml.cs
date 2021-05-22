using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DnDIniativeTracker.Services;
using DnDIniativeTracker.Dtos;

namespace DnDIniativeTracker.Pages
{
    public class CreateCreature : PageModel
    {
        private readonly ICreatureService _creatureService;

        public CreateCreature(ICreatureService creatureService)
        {
            _creatureService = creatureService;
        }

        public IActionResult OnGet()
        {
            return this.Page();
        }

        public IActionResult OnPost()  
        {   
            if(!ModelState.IsValid)
            {
                return this.Page();   
            }
            _creatureService.CreateCreature(CreatureCreateDto);

            if(_creatureService.GetCreatureByName(CreatureCreateDto.Name) != null)
            {
                ViewData["Success"] = "Creature created.";
            }

            return this.Page();  
        }

        [BindProperty]
        public CreatureCreateDto CreatureCreateDto { get; set; }

    }
}