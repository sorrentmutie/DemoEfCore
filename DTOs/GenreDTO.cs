using System.ComponentModel.DataAnnotations;

namespace MyAPI.DTOs;

public class GenreCreationDTO
{
    [StringLength(maximumLength: 150)]
    public string Name { get; set; } = null!;   
}

public class  GenreDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
  //  public List<Movie> Movies { get; set; } = new List<Movie>();
}
