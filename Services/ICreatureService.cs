using System.Collections.Generic;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public interface ICreatureService
    {
        void CreateCreature(CreatureCreateDto creatureCreateDto);
        void UpdateCreature(Creature creatureModel);
        void DeleteCreature(int id);
        Creature GetCreatureByName(string name);
        Creature GetCreatureById(int id);
        IEnumerable<Creature> GetCreatures();
        IEnumerable<Creature> GetCreaturesByRole(Creature.Roles role);
        CreatureUpdateDto MapCreatureToCreatureUpdateDto(Creature creatureModel);
        void UpdateCreature(CreatureUpdateDto creatureUpdateDto);
    }
}