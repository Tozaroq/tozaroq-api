using Microsoft.EntityFrameworkCore;

namespace Tozaroq.Api.Data
{
    public class TozaroqDbContext : DbContext
    {
        public TozaroqDbContext(DbContextOptions<TozaroqDbContext> options) : base(options) { }
    }
}
