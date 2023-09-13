using Microsoft.EntityFrameworkCore;

namespace ProductRegister.Infra;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
