using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Match
{
    public int Id { get; set; }
    [Required]
    public int WinnerId { get; set; }
    [Required]
    public int LoserId { get; set; }
    public DateTime TimeStamp { get; set; } = DateTime.Now;
}
