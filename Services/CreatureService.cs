using System.Collections.Generic;
using DnDIniativeTracker.Data;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public class CreatureService : ICreatureService
    {
        private readonly ICreatureRepository _creatureRepository;

        public CreatureService(ICreatureRepository creatureRepository)
        {
            _creatureRepository = creatureRepository;
        }

        public void CreateCreature(Creature creatureModel)
        {
            _creatureRepository.CreateCreature(creatureModel);
            _creatureRepository.SaveChanges();
        }

        public Creature GetCreatureById(int id)
        {
            return _creatureRepository.GetCreatureById(id);
        }

        public Creature GetCreatureByName(string name)
        {
            return _creatureRepository.GetCreatureByName(name);
        }

        public IEnumerable<Creature> GetCreatures()
        {
            return _creatureRepository.GetCreatures();
        }

        public IEnumerable<Creature> GetCreaturesByRole(Creature.Roles role)
        {
            return _creatureRepository.GetCreaturesByRole(role);
        }

        public void UpdateCreature(Creature creatureModel)
        {
            _creatureRepository.UpdateCreature(creatureModel);
            _creatureRepository.SaveChanges();
        }
    }
}