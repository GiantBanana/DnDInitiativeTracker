using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DnDIniativeTracker.Services;
using System.Collections.Generic;
using DnDIniativeTracker.Models;
using DnDIniativeTracker.KeylessModels;
using DnDIniativeTracker.Dtos;

namespace DnDIniativeTracker.Pages
{
    public class HomePage : PageModel
    {
        private readonly IGameService _gameService;

        public HomePage(IGameService gameService)
        {
            _gameService = gameService;
        }

        public IActionResult OnGet(string game)
        {
            Games = (List<Game>) _gameService.GetGames();
            return this.Page();
        }

        public List<Game> Games { get; set; }

    }
}