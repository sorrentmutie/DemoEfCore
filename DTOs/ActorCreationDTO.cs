

namespace MyAPI.DTOs;

public class ActorCreationDTO
{
    [StringLength(150)] 
    public string? Name { get; set; } = null!;
    public double Salary { get; set; }
    public DateTime Birthday { get; set; }
}

public class ActorDTO
{
    public int Id { get; set; }
    public string? Name { get; set; } = null!;
    public double Salary { get; set; }
    public DateTime Birthday { get; set; }
}
