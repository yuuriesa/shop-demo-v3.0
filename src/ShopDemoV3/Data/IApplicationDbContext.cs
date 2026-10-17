using Microsoft.EntityFrameworkCore;

namespace ShopDemoV3.Data
{
    public interface IApplicationDbContext
    {
        public int SaveChanges();
    }
}