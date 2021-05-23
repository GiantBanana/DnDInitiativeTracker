namespace DnDIniativeTracker.Models
{
    public class CreatureInGame
    {
        public int Id { get; set; }
        public string TempName { get; set; }
        public int Initiative { get; set; }
        public int HP { get; set; }

        public int CreatureId { get; set; }
        public Creature Creature { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }
       
        public CreatureInGame(Creature creature, int gameId, string tempName)
        {
            CreatureId = creature.Id;
            Initiative = creature.Initiative;
            HP = creature.HP;
            GameId = gameId;
            TempName = tempName;
        }

        public CreatureInGame(Creature creature, int gameId)
        {
            CreatureId = creature.Id;
            Initiative = creature.Initiative;
            HP = creature.HP;
            GameId = gameId;
        }

        public CreatureInGame()
        {
        }
    }
}