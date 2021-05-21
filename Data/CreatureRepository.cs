using System;
using System.Collections.Generic;
using System.Linq;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Data
{
    public class CreatureRepository : ICreatureRepository
    {
        private readonly DnDContext _context;

        public CreatureRepository(DnDContext context)
        {
            _context = context;
        }

        public void CreateCreature(Creature creatureModel)
        {
            if(creatureModel == null)
            {
                throw new ArgumentNullException(nameof(creatureModel));
            }

            _context.Creatures.Add(creatureModel);
        }

        public Creature GetCreatureById(int id)
        {
            return _context.Creatures.Where(c => c.Id == id).FirstOrDefault();
        }

        public Creature GetCreatureByName(string name)
        {
            return _context.Creatures.Where(c => c.Name == name).FirstOrDefault();
        }

        public IEnumerable<Creature> GetCreatures()
        {
            return _context.Creatures.ToList();
        }

        public IEnumerable<Creature> GetCreaturesByRole(Creature.Roles role)
        {
            return _context.Creatures.Where(c => c.Role == role).ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCreature(Creature creatureModel)
        {
            _context.Creatures.Update(creatureModel);
        }
    }
}