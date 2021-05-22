using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DnDIniativeTracker.Services;
using System.Collections.Generic;
using DnDIniativeTracker.Models;
using DnDIniativeTracker.KeylessModels;
using DnDIniativeTracker.Dtos;

namespace DnDIniativeTracker.Pages
{
    public class GamePage : PageModel
    {
        private readonly ICreatureService _creatureService;
        private readonly IGameService _gameService;
        private readonly ICreatureInGameService _creatureInGameService;

        public GamePage(ICreatureService creatureService, IGameService gameService, ICreatureInGameService creatureInGameService)
        {
            _creatureService = creatureService;
            _gameService = gameService;
            _creatureInGameService = creatureInGameService;
            Creatures = (List<Creature>) _creatureService.GetCreatures();
        }

        public IActionResult OnGet(string game)
        {
            Game = _gameService.GetGameByName(game);
            CreaturesInGame = (List<CreatureInGame>)_creatureInGameService.GetCreaturesInGameByGameId(Game.Id);
            return this.Page();
        }

        public IActionResult OnPost(string game)
        {
            Game = _gameService.GetGameByName(game);
            if(ModelState.IsValid)
            {
                _gameService.AddCreaturesToGame(AddCreature ,Game);
            }
            CreaturesInGame = (List<CreatureInGame>)_creatureInGameService.GetCreaturesInGameByGameId(Game.Id);
            return this.Page();
        }



        public List<Creature> Creatures { get; set; }
        public List<CreatureInGame> CreaturesInGame { get; set; }
        public Game Game { get; set; }
       
        [BindProperty]
        public AddCreature AddCreature { get; set; }

        public CreatureInGameUpdateDto CreatureInGameUpdateDto { get; set; }

    }
}