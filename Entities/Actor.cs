namespace MyAPI.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public double Salary { get; set; }
        public DateTime Birthday { get; set; }
        public HashSet<MovieActor> MoviesActors { get; set; } = new HashSet<MovieActor>();
    }
}
