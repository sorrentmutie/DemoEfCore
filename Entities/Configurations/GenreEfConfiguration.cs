namespace MyAPI.Entities.Configurations;

public class GenreEfConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.Property(g => g.Name).IsRequired(); //.HasMaxLength(150);
                                                    // builder.Entity<Genre>().Property(g => g.Name).IsRequired(); //.HasMaxLength(150);

        builder.HasData(
                       new Genre { Id = 8, Name = "Historical" },
                       new Genre { Id = 9, Name = "Fantasy" });                         
    }
}
