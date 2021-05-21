using System.Collections.Generic;

namespace DnDIniativeTracker.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<CreatureInGame> CreaturesInGame { get; set; } 
     }
}