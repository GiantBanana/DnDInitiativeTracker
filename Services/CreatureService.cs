using System.Collections.Generic;
using AutoMapper;
using DnDIniativeTracker.Data;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public class CreatureService : ICreatureService
    {
        private readonly ICreatureRepository _creatureRepository;
        private readonly IMapper _mappper;

        public CreatureService(ICreatureRepository creatureRepository, IMapper mappper)
        {
            _creatureRepository = creatureRepository;
            _mappper = mappper;
        }

        public void CreateCreature(CreatureCreateDto creatureCreateDto)
        {
            var creatureModel = _mappper.Map<Creature>(creatureCreateDto);
            _creatureRepository.CreateCreature(creatureModel);
            _creatureRepository.SaveChanges();
        }

        public void DeleteCreature(int id)
        {
            var creatureModel = _creatureRepository.GetCreatureById(id);
            _creatureRepository.DeleteCreature(creatureModel);
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

        public CreatureUpdateDto MapCreatureToCreatureUpdateDto(Creature creatureModel)
        {
            return _mappper.Map<CreatureUpdateDto>(creatureModel);
        }

        public void UpdateCreature(Creature creatureModel)
        {
            _creatureRepository.UpdateCreature(creatureModel);
            _creatureRepository.SaveChanges();
        }

        public void UpdateCreature(CreatureUpdateDto creatureUpdateDto)
        {
            var creatureModel = _creatureRepository.GetCreatureById(creatureUpdateDto.Id);
            _mappper.Map(creatureUpdateDto,creatureModel);
            _creatureRepository.UpdateCreature(creatureModel);
            _creatureRepository.SaveChanges();
        }
    }
}