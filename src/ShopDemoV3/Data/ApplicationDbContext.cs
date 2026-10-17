using Microsoft.EntityFrameworkCore;

namespace ShopDemoV3.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options: options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connetionString = "Server=localhost;Database=ShopDemoV3;User=SA;Password=Password123!;TrustServerCertificate=True;MultipleActiveResultSets=true";
            optionsBuilder.UseSqlServer(connectionString: connetionString);
        }
    }
}