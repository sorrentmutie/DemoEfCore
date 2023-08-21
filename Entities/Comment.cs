namespace MyAPI.Entities;

public class Comment: BaseEntity
{
    public string? Body { get; set; } = null!;
    public bool Reccomend { get; set; }
    public int MovieId { get; set; }
    public Movie? Movie { get; set; } = null!;

  //  public int MovieId { get; set; }
  //  public Movie Movie { get; set; } = null!;
}
