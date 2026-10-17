using Microsoft.EntityFrameworkCore;

namespace ShopDemoV3.Data
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options: options)
        {
            
        }
    }
}