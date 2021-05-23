using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DnDIniativeTracker.Services;
using System.Collections.Generic;
using DnDIniativeTracker.Models;
using DnDIniativeTracker.KeylessModels;
using DnDIniativeTracker.Dtos;

namespace DnDIniativeTracker.Pages
{
    public class CreaturePage : PageModel
    {
        private readonly ICreatureService _creatureService;

        public CreaturePage(ICreatureService creatureService)
        {
            _creatureService = creatureService;
            Creatures = (List<Creature>) _creatureService.GetCreatures();
        }

        public IActionResult OnGet(string game)
        {
            return this.Page();
        }



        public List<Creature> Creatures { get; set; }

    }
}