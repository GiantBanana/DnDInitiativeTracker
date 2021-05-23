using System.Collections.Generic;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.KeylessModels;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public interface IGameService
    {
        void CreateGame(Game gameModel);
        void UpdateGame(Game gameModel);
        void AddCreaturesToGame(AddCreature addCreature, Game game);
        Game GetGameByName(string name);
        Game GetGameById(int id);
        IEnumerable<Game> GetGames();
        void CreateGame(GameCreateDto gameCreateDto);
    }
}