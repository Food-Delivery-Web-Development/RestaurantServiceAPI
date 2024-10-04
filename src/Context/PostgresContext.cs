using Microsoft.EntityFrameworkCore;

namespace Restaurant.Service.Context;

public class PostgresContext(DbContextOptions<PostgresContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostgresContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
