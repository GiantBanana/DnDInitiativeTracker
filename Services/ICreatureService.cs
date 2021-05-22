using System.Collections.Generic;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public interface ICreatureService
    {
        void CreateCreature(CreatureCreateDto creatureCreateDto);
        void UpdateCreature(Creature creatureModel);
        Creature GetCreatureByName(string name);
        Creature GetCreatureById(int id);
        IEnumerable<Creature> GetCreatures();
        IEnumerable<Creature> GetCreaturesByRole(Creature.Roles role);
    }
}