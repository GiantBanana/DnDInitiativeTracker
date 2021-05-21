using System.Collections.Generic;

namespace DnDIniativeTracker.Models
{
    public class Creature
    {
        public enum Roles { Player, NPC, Monster};
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int Initiative { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public Roles Role { get; set; }  
        public int DexBonus { get; set; }

        public IList<CreatureInGame> CreatureInGames { get; set; } 
    }
}