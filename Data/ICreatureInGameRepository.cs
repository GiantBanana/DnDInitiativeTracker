using System.Collections.Generic;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Data
{
    public interface ICreatureInGameRepository
    {
        void UpdateCreatureInGame(CreatureInGame creatureInGameModel);
        bool SaveChanges();
        CreatureInGame GetCreatureInGameById(int id);
        IEnumerable<CreatureInGame> GetCreaturesInGame();
        IEnumerable<CreatureInGame> GetCreaturesInGameByGameId(int id);
    }
}