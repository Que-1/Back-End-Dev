using Microsoft.EntityFrameworkCore;
namespace Project3.Models
{
    public class AnalystContext: DbContext
    {
        public AnalystContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<SystemAnalyst> SystemAnalysts { get; set; }
    }
}
