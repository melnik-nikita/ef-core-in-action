namespace Introduction;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

public class AppDbContext : DbContext
{
    private const string ConnectionString = @"Server=(local);Database=MyFirstEfCoreDb;User Id=SA;Password=P@ssw0rd!;";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
        optionsBuilder.LogTo((@string) => Console.WriteLine(@string), LogLevel.Information);
    }

    public DbSet<Book> Books { get; set; }
}
