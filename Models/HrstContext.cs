using Microsoft.EntityFrameworkCore;

namespace HRSTAPI.Models
{
    public class HrstContext: DbContext
    {

        public HrstContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<HrstDetail> HrstDetails { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
    }
}
