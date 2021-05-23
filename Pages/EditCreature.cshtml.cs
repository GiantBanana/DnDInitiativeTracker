using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DnDIniativeTracker.Services;
using DnDIniativeTracker.Dtos;

namespace DnDIniativeTracker.Pages
{
    public class EditCreaturePage : PageModel
    {
        private readonly ICreatureService _creatureService;

        public EditCreaturePage(ICreatureService creatureService)
        {
            _creatureService = creatureService;
        }

        public IActionResult OnGet(int id)
        {
            CreatureUpdateDto =_creatureService.MapCreatureToCreatureUpdateDto(_creatureService.GetCreatureById(id));
            return this.Page();
        }

        public IActionResult OnPost(int id)  
        {   
            if(!ModelState.IsValid)
            {
                return this.Page();   
            }
            _creatureService.UpdateCreature(CreatureUpdateDto);
            ViewData["Success"] = "Creature edited.";

            return this.Page();
        }

        [BindProperty]
        public CreatureUpdateDto CreatureUpdateDto { get; set; }

    }
}