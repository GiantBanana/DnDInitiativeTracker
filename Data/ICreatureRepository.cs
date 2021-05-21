using System.Collections.Generic;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Data
{
    public interface ICreatureRepository
    {
        void CreateCreature(Creature creatureModel);
        void UpdateCreature(Creature creatureModel);
        bool SaveChanges();
        Creature GetCreatureByName(string name);
        Creature GetCreatureById(int id);
        IEnumerable<Creature> GetCreatures();
        IEnumerable<Creature> GetCreaturesByRole(Creature.Roles role);
    }
}