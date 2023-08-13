using Microsoft.EntityFrameworkCore;

namespace htt_test_case.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Goods> Goods { get; set; } = null!;
        public DbSet<Categories> Categories { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options) { }

    }
}
