using static DnDIniativeTracker.Models.Creature;

namespace DnDIniativeTracker.Dtos
{
    public class CreatureUpdateDto : CreatureDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Initiative { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public Roles Role { get; set; }  
    }
}