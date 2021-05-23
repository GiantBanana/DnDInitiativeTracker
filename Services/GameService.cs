using System.Collections.Generic;
using AutoMapper;
using DnDIniativeTracker.Data;
using DnDIniativeTracker.Dtos;
using DnDIniativeTracker.KeylessModels;
using DnDIniativeTracker.Models;

namespace DnDIniativeTracker.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;
        private readonly ICreatureService _creatureService;
        private readonly IMapper _mapper;

        public GameService(IGameRepository gameRepository, ICreatureService creatureService, IMapper mapper)
        {
            _gameRepository = gameRepository;
            _creatureService = creatureService;
            _mapper = mapper;
        }

        public void AddCreaturesToGame(AddCreature addCreature, Game game)
        {
            if(game.CreaturesInGame == null)
            {
                game.CreaturesInGame = new List<CreatureInGame>();
            }
            var creatureModel = _creatureService.GetCreatureById(addCreature.CreatureId);
            for(var i = 0; i < addCreature.Number; i++)
            {
                game.CreaturesInGame.Add(new CreatureInGame(creatureModel,game.Id,$"{creatureModel.Name} - {i}"));
            }
            UpdateGame(game);
        }

        public void CreateGame(Game gameModel)
        {
            _gameRepository.CreateGame(gameModel);
            _gameRepository.SaveChanges();
        }

        public void CreateGame(GameCreateDto gameCreateDto)
        {
            var gameModel = _mapper.Map<Game>(gameCreateDto);
            _gameRepository.CreateGame(gameModel);
            _gameRepository.SaveChanges();
        }

        public Game GetGameById(int id)
        {
            return _gameRepository.GetGameById(id);
        }

        public Game GetGameByName(string name)
        {
            return _gameRepository.GetGameByName(name);
        }

        public IEnumerable<Game> GetGames()
        {
            return _gameRepository.GetGames();
        }

        public void UpdateGame(Game gameModel)
        {
            _gameRepository.UpdateGame(gameModel);
            _gameRepository.SaveChanges();
        }
    }
}