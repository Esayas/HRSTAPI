using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRSTAPI.Models
{
    public class HrstContext : IdentityDbContext<AppUser>
    {

        public HrstContext(DbContextOptions<HrstContext> options) : base(options)
        {
        }

        public DbSet<HrstDetail> HrstDetails { get; set; }
        public DbSet<LookUp> LookUps { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Facility> Facilities { get; set; }
    }
}
