namespace MyAPI.Entities;

public class Movie: BaseEntity
{
    public string? Title { get; set; } = null!;
    public bool InTheaters { get; set; }
    public string? Description { get; set; } = null!;
    public string? Director { get; set; } = null!;
    public string? ImageUrl { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();
    public HashSet<Genre> Genres { get; set; } = new HashSet<Genre>();
    public List<MovieActor> MoviesActors { get; set; } = new List<MovieActor>();  


    //public int GenreId { get; set; }
    //public Genre Genre { get; set; } = null!;
    //public ICollection<Actor> Actors { get; set; } = new List<Actor>();
}
