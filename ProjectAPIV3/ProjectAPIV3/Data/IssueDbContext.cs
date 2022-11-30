using Microsoft.EntityFrameworkCore;
using ProjectAPIV3.Model;

namespace ProjectAPIV3.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            : base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
