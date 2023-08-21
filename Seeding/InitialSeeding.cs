namespace MyAPI.Seeding;

public class InitialSeeding
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var actor1 = new Actor { Id = 11, Name = "John Doe", Salary = 1500000, Birthday = new DateTime(1983,3,1) };
        var actor2 = new Actor { Id = 12, Name = "Luigi Bianchi", Salary = 500000, Birthday = new DateTime(1968, 8, 15) };
        var actor3 = new Actor { Id = 13, Name = "Mario Rossi", Salary = 800000, Birthday = new DateTime(1975, 8, 15) };
        modelBuilder.Entity<Actor>().HasData(actor1, actor2, actor3);
    }
}
