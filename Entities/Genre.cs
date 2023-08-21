namespace MyAPI.Entities;

public class Genre
{
    public int Id { get; set; }
    public string? Name { get; set; }  
    public HashSet<Movie> Movies { get; set; } = new HashSet<Movie>();
}
