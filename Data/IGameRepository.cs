using System.Collections.Generic;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Data
{
    public interface IGameRepository
    {
        void CreateGame(Game gameModel);
        void UpdateGame(Game gameModel);
        bool SaveChanges();
        Game GetGameByName(string name);
        Game GetGameById(int id);
        IEnumerable<Game> GetGames();
    }
}