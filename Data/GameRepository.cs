using System;
using System.Collections.Generic;
using System.Linq;
using DnDIniativeTracker.Models;
using Microsoft.EntityFrameworkCore;


namespace DnDIniativeTracker.Data
{
    public class GameRepository : IGameRepository
    {
        private readonly DnDContext _context;

        public GameRepository(DnDContext context)
        {
            _context = context;
        }

        public void CreateGame(Game gameModel)
        {
            if(gameModel == null)
            {
                throw new ArgumentNullException(nameof(gameModel));
            }

            _context.Games.Add(gameModel);
        }

        public Game GetGameById(int id)
        {
            return _context.Games.Where(g => g.Id == id).Include(g => g.CreaturesInGame).FirstOrDefault();
        }

        public Game GetGameByName(string name)
        {
            return _context.Games.Where(g => g.Name == name).Include(g => g.CreaturesInGame).FirstOrDefault();
        }

        public IEnumerable<Game> GetGames()
        {
            return _context.Games.Include(g => g.CreaturesInGame).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateGame(Game gameModel)
        {
            _context.Games.Update(gameModel);
        }
    }
}