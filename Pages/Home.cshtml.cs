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
            Games = (List<Game>) _gameService.GetGames();
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
            _gameService.CreateGame(GameCreateDto);
            if(_gameService.GetGameByName(GameCreateDto.Name) != null)
            {
                ViewData["Success"] = "Game created.";
            }
            Games = (List<Game>) _gameService.GetGames();
            return this.Page();
        }

        public List<Game> Games { get; set; }

        [BindProperty]
        public GameCreateDto GameCreateDto { get; set; }

    }
}