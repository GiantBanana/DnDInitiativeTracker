using System.Collections.Generic;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public interface ICreatureService
    {
        void CreateCreature(Creature creatureModel);
        void UpdateCreature(Creature creatureModel);
        Creature GetCreatureByName(string name);
        Creature GetCreatureById(int id);
        IEnumerable<Creature> GetCreatures();
        IEnumerable<Creature> GetCreaturesByRole(Creature.Roles role);
    }
}