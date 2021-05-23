using System.Collections.Generic;
using DnDIniativeTracker.Data;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.KeylessModels;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public class CreatureInGameService : ICreatureInGameService
    {
        private readonly ICreatureInGameRepository _creatureInGameRepository;

        public CreatureInGameService(ICreatureInGameRepository creatureInGameRepository)
        {
            _creatureInGameRepository = creatureInGameRepository;
        }

        public void DeleteCreatureInGameById(int id)
        {
            var creatureInGameModel = _creatureInGameRepository.GetCreatureInGameById(id);
            _creatureInGameRepository.DeleteCreatureInGame(creatureInGameModel);
            _creatureInGameRepository.SaveChanges();
        }

        public CreatureInGame GetCreatureInGameById(int id)
        {
            return _creatureInGameRepository.GetCreatureInGameById(id);
        }

        public IEnumerable<CreatureInGame> GetCreaturesInGame()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CreatureInGame> GetCreaturesInGameByGameId(int id)
        {
            return _creatureInGameRepository.GetCreaturesInGameByGameId(id);
        }

        public void UpdateCreatureInGame(CreatureInGameUpdateDto creatureInGameUpdateDto)
        {
            var creatureInGameModel = GetCreatureInGameById(creatureInGameUpdateDto.Id);
            creatureInGameModel.Initiative = creatureInGameUpdateDto.Initiative;
            creatureInGameModel.HP = creatureInGameUpdateDto.HP;
            _creatureInGameRepository.UpdateCreatureInGame(creatureInGameModel);
            _creatureInGameRepository.SaveChanges();
        }
    }
}