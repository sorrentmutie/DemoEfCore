using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MyAPI.DTOs;

public class MovieCreationDTO
{
    [StringLength(150)]
    public string? Title { get; set; } = null!;
    public bool InTheaters { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<int> Genres { get; set; }  = new List<int>();
    public List<int> Actors { get; set; }  = new List<int>();
    public List<MovieActorCreationDTO> MoviesActors { get; set; } = new List<MovieActorCreationDTO>();
}

public class  MovieActorCreationDTO
{
    public int ActorId { get; set; }
    public string? Character { get; set; } = null!;
    public int Order { get; set; }
}

public class MovieActorDTO
{
    public int ActorId { get; set; }
    public string? Character { get; set; } = null!;
    public int Order { get; set; }
    public string? ActorName { get; set; } = null!;
}
public class MovieDTO
{
    public string? Title { get; set; } = null!;
    public bool InTheaters { get; set; }
    public string? Description { get; set; } = null!;
    public string? Director { get; set; } = null!;
    public string? ImageUrl { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    public List<MovieActorDTO> MovieActors { get; set; } = new List<MovieActorDTO>();
    public List<GenreDTO> Genres { get; set; } = new List<GenreDTO>();  
}
