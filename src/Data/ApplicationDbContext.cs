namespace Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        Database.EnsureCreated();
    }

    public DbSet<User>? Users { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer
            (connectionString: "YOUR_CONNECTION_STRING");

        base.OnConfiguring(optionsBuilder);
    }
}
