namespace MyAPI.DTOs;

public class CommentCreationDTO
{
    public string? Body { get; set; } = null!;
    public bool Reccomend { get; set; }
}

public class CommentDTO
{
    public int Id { get; set; } 
    public string? Body { get; set; } = null!;
    public bool Reccomend { get; set; }
}

