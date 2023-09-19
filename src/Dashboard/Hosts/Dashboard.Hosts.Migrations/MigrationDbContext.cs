using Microsoft.EntityFrameworkCore;
using Dashboard.Infrastructure.DataAccess;

namespace Dashboard.Hosts.Migrations
{
    public class MigrationDbContext : BaseDbContext
    {
        public MigrationDbContext(DbContextOptions<MigrationDbContext> options) : base(options) { }
    }
}
