using System.Collections.Generic;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public interface ICreatureInGameService
    {
        void UpdateCreatureInGame(CreatureInGameUpdateDto creatureInGameUpdateDto);
        CreatureInGame GetCreatureInGameById(int id);
        IEnumerable<CreatureInGame> GetCreaturesInGame();
        IEnumerable<CreatureInGame> GetCreaturesInGameByGameId(int id);
    }
}