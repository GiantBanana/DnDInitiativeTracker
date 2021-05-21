namespace DnDIniativeTracker.Dtos
{
    public class CreatureInGameUpdateDto : CreatureInGameDto
    {
        public int Id { get; set; }
        public int Initiative { get; set; }
        public int HP { get; set; }
    }
}