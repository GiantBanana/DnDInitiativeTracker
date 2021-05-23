using System.ComponentModel.DataAnnotations;

namespace DnDIniativeTracker.Dtos
{
    public class GameCreateDto : GameDto
    {
        [Required]
        public string Name { get; set; }
    }
}