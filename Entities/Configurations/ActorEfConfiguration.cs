namespace MyAPI.Entities.Configurations;

public class ActorEfConfiguration: IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.Property(a => a.Name).IsRequired(); //.HasMaxLength(150);
        builder.Property(a => a.Birthday).HasColumnType("date");
        builder.Property(a => a.Salary).HasColumnType("decimal(18,2)");
    }
}

