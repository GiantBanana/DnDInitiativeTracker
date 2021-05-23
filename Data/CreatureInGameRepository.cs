using System.Collections.Generic;
using System.Linq;
using DnDIniativeTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDIniativeTracker.Data
{
    public class CreatureInGameRepository : ICreatureInGameRepository
    {
        private readonly DnDContext _context;

        public CreatureInGameRepository(DnDContext context)
        {
            _context = context;
        }

        public void DeleteCreatureInGame(CreatureInGame creatureInGameModel)
        {
            _context.CreaturesInGames.Remove(creatureInGameModel);
        }

        public CreatureInGame GetCreatureInGameById(int id)
        {
            return _context.CreaturesInGames.Include(c => c.Creature).Include(c => c.Game).FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<CreatureInGame> GetCreaturesInGame()
        {
            return _context.CreaturesInGames.ToList();
        }

        public IEnumerable<CreatureInGame> GetCreaturesInGameByGameId(int id)
        {
            return _context.CreaturesInGames.Where(c => c.GameId == id).OrderByDescending(c => c.Initiative).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCreatureInGame(CreatureInGame creatureInGameModel)
        {
            _context.CreaturesInGames.Update(creatureInGameModel);
        }
    }
}